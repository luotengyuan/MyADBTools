using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyADBTools
{
    public partial class Form_wifi_debug : Form
    {
        NetworkAdapterUtil netAdapterUtil = new NetworkAdapterUtil();
        List<NetworkAdapter> netCardList = new List<NetworkAdapter>();

        QRCodeUtil qrCode = new QRCodeUtil();

        public Form_wifi_debug()
        {
            InitializeComponent();
        }

        private void Form_wifi_debug_Load(object sender, EventArgs e)
        {
            readNetCard();
            pb_apk_download.Image = qrCode.BarcodeImage("https://www.pgyer.com/MyWifiAdbTools");
            tb_port.Text = Form_main.port.ToString();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            readNetCard();
        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {

        }

        private void readNetCard()
        {
            netCardList.Clear();
            cb_slt_netcard.Items.Clear();
            netCardList = netAdapterUtil.GetAllNetworkAdapters();
            if (netCardList == null)
            {
                MessageBox.Show("读取网卡适配器错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (netCardList.Count <= 0)
            {
                MessageBox.Show("没有获取到可用的网卡适配器！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (NetworkAdapter item in netCardList)
            {
                cb_slt_netcard.Items.Add(item.Serial + " --> " + item.Description);
            }
            cb_slt_netcard.SelectedIndex = 0;
        }

        private void cb_slt_netcard_SelectedValueChanged(object sender, EventArgs e)
        {
            tb_ip.Text = "";
            NetworkAdapter sltNetCard = getSltNetCard(cb_slt_netcard.SelectedIndex);
            if (sltNetCard == null)
            {
                MessageBox.Show("选择的网卡信息错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sltNetCard.IPAddresses != null)
            {
                foreach (var item in sltNetCard.IPAddresses)
                {
                    //判断是否为ipv4
                    if (item.Address == null || item.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;
                    if (item.Address != null)
                    {
                        Console.WriteLine("IP 地址：" + item.Address.ToString());   //IP地址
                        tb_ip.Text = item.Address.ToString();
                        pb_socket_server.Image = qrCode.BarcodeImage(item.Address.ToString() + " --> " + Form_main.port.ToString());
                    }
                }
            }
        }

        private NetworkAdapter getSltNetCard(int serial)
        {
            if (netCardList == null)
            {
                return null;
            }
            foreach (NetworkAdapter item in netCardList)
            {
                if (serial == item.Serial)
                {
                    return item;
                }
            }
            return null;
        }

        private bool IsValidIp(string strIn)
        {
            if (strIn == null)
            {
                return false;
            }
            bool b = Regex.IsMatch(strIn, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
            return b;
        }

    }
}

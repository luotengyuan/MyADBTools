using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;

namespace MyADBTools
{
    class NetworkAdapter
    {
        int serial;

        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        NetworkInterfaceType networkInterfaceType;

        public NetworkInterfaceType NetworkInterfaceType
        {
            get { return networkInterfaceType; }
            set { networkInterfaceType = value; }
        }

        long speed;

        public long Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        PhysicalAddress macAddress;

        public PhysicalAddress MacAddress
        {
            get { return macAddress; }
            set { macAddress = value; }
        }

        string networkInterfaceID;

        public string NetworkInterfaceID
        {
            get { return networkInterfaceID; }
            set { networkInterfaceID = value; }
        }

        GatewayIPAddressInformationCollection getwaryes;

        public GatewayIPAddressInformationCollection Getwaryes
        {
            get { return getwaryes; }
            set { getwaryes = value; }
        }

        UnicastIPAddressInformationCollection iPAddresses;

        public UnicastIPAddressInformationCollection IPAddresses
        {
            get { return iPAddresses; }
            set { iPAddresses = value; }
        }

        IPAddressCollection dhcpServerAddresses;

        public IPAddressCollection DhcpServerAddresses
        {
            get { return dhcpServerAddresses; }
            set { dhcpServerAddresses = value; }
        }

        bool isDhcpEnabled;

        public bool IsDhcpEnabled
        {
            get { return isDhcpEnabled; }
            set { isDhcpEnabled = value; }
        }

        IPAddressCollection dnsAddresses;

        public IPAddressCollection DnsAddresses
        {
            get { return dnsAddresses; }
            set { dnsAddresses = value; }
        }

        /// <summary>
        /// 设置IP地址
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="submask"></param>
        /// <param name="getway"></param>
        /// <param name="dns"></param>
        public bool SetIPAddress(string[] ip, string[] submask, string[] getway)
        {
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            string str = "";
            foreach (ManagementObject mo in moc)
            {

                //if (!(bool)mo["IPEnabled"])
                //    continue;


                if (this.NetworkInterfaceID == mo["SettingID"].ToString())
                {
                    bool isModf = false;
                    if (ip != null && submask != null)
                    {
                        string caption = mo["Caption"].ToString(); //描述
                        inPar = mo.GetMethodParameters("EnableStatic");
                        inPar["IPAddress"] = ip;
                        inPar["SubnetMask"] = submask;
                        outPar = mo.InvokeMethod("EnableStatic", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        isModf = true;
                        if (str != "0" && str != "1") return false;
                        //获取操作设置IP的返回值， 可根据返回值去确认IP是否设置成功。 0或1表示成功 
                        // 返回值说明网址： https://msdn.microsoft.com/en-us/library/aa393301(v=vs.85).aspx
                    }
                    if (getway != null)
                    {
                        inPar = mo.GetMethodParameters("SetGateways");
                        inPar["DefaultIPGateway"] = getway;
                        outPar = mo.InvokeMethod("SetGateways", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        isModf = true;
                        if (str != "0" && str != "1") return false;
                    }
                    if (isModf)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// 1 设置IP地址的代码。（设置IP地址，修改IP地址需要管理员权限）
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="submask"></param>
        /// <param name="getway"></param>
        /// <param name="dns"></param>
        public bool SetIPAddress(string[] ip, string[] submask, string[] getway, string[] dns)
        {
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            string str = "";
            foreach (ManagementObject mo in moc)
            {

                if (!(bool)mo["IPEnabled"])
                    continue;

                if (this.NetworkInterfaceID == mo["SettingID"].ToString())
                {
                    bool isModf = false;
                    if (ip != null && submask != null)
                    {
                        string caption = mo["Caption"].ToString(); //描述
                        inPar = mo.GetMethodParameters("EnableStatic");
                        inPar["IPAddress"] = ip;
                        inPar["SubnetMask"] = submask;
                        outPar = mo.InvokeMethod("EnableStatic", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        isModf = true;
                        if (str != "0" && str != "1") return false;
                        //获取操作设置IP的返回值， 可根据返回值去确认IP是否设置成功。 0或1表示成功 
                        // 返回值说明网址： https://msdn.microsoft.com/en-us/library/aa393301(v=vs.85).aspx
                    }
                    if (getway != null)
                    {
                        inPar = mo.GetMethodParameters("SetGateways");
                        inPar["DefaultIPGateway"] = getway;
                        outPar = mo.InvokeMethod("SetGateways", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        isModf = true;
                        if (str != "0" && str != "1") return false;
                    }
                    if (dns != null)
                    {
                        inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        inPar["DNSServerSearchOrder"] = dns;
                        outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        isModf = true;
                        if (str != "0" && str != "1") return false;
                    }
                    else
                    {
                        // 设置DNS为空
                        mo.InvokeMethod("SetDNSServerSearchOrder", null);
                        isModf = true;
                        return true;
                    }
                    if (isModf)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// 2 设置IP为自动获取
        /// 启用DHCP服务
        /// </summary>
        public bool EnableDHCP()
        {

            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();

            ManagementBaseObject outPar = null;
            string str = "";

            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"])
                    continue;

                if (mo["SettingID"].ToString() == this.NetworkInterfaceID) //网卡接口标识是否相等, 相当只设置指定适配器IP地址
                {
                    mo.InvokeMethod("SetDNSServerSearchOrder", null);
                    mo.InvokeMethod("EnableDHCP", null);
                    return true;
                }
            }
            return false;
        }

    }
}

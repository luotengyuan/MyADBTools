using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MyADBTools
{
    public partial class Form_main : Form
    {
        public string SelectedDevice = "";

        public bool AlwaysClearConsole = false;
        /// <summary>
        /// UDP服务监听端口号
        /// </summary>
        public static int port = 10720;
        /// <summary>
        /// UDP服务
        /// </summary>
        private Socket udpServer;
        private Thread udpThread;
        private string requestStr = "MyWifiAdbTools";

        private int wifi_debug_port = 5555;

        private Thread deviceInfoThread = null;
        private bool deviceInfoThreadRunning = false;

        public Form_main()
        {
            InitializeComponent();
            startUdpServer();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            this.Text += " V" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopUdpServer();
            if (deviceInfoThread != null)
            {
                deviceInfoThread.Abort();
            }
            Environment.Exit(0);
        }

        private void startUdpServer()
        {
            //1.创建服务器端电话
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //2.创建手机卡
            IPAddress ip = IPAddress.Any;
            IPEndPoint endPoint = new IPEndPoint(ip, port);
            //3.将电话卡插进电话中(绑定端口号和IP)
            udpServer.Bind(endPoint);
            Console.WriteLine("服务器已经成功开启!");
            //开启接收消息线程
            udpThread = new Thread(ReciveUdpMsg);
            //udpThread.IsBackground = true;
            udpThread.Start();
        }

        private void stopUdpServer()
        {
            udpServer.Close();
            udpThread.Abort();
        }

        /// <summary>
        /// 接收发送给本机ip对应端口号的数据
        /// </summary>
        void ReciveUdpMsg()
        {
            while (true)
            {
                try
                {
                    EndPoint point = new IPEndPoint(IPAddress.Any, 0);//用来保存发送方的ip和端口号
                    byte[] buffer = new byte[1024 * 1024];
                    int length = udpServer.ReceiveFrom(buffer, ref point);//接收数据报
                    string message = Encoding.UTF8.GetString(buffer, 0, length);
                    //listBox1.Items.Add(point.ToString() + "：" + message);
                    Console.WriteLine(point.ToString() + "：" + message);
                    if (requestStr.Equals(message))
                    {
                        Action action = () =>
                        {
                            string ip = point.ToString().Split(':')[0];
                            DialogResult result = MessageBox.Show("接收到【" + ip + "】的连接请求，是否连接调试？");
                            if (result == System.Windows.Forms.DialogResult.OK)
                            {
                                string ret = ExecuteWithOutput("adb connect " + ip + ":" + wifi_debug_port);
                                if (ret != null && ret.ToLower().Contains("connected to " + ip + ":" + wifi_debug_port))
                                {
                                    MessageBox.Show("连接成功");
                                    btn_refresh.PerformClick();
                                }
                                else
                                {
                                    MessageBox.Show("连接失败\r\n" + ret);
                                }
                            }
                        };
                        Invoke(action);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void cb_slt_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDevice = cb_slt_devices.Text.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // 刷新连接的设备
            //string ret = ExecuteWithOutput("adb devices -l");
            string ret = ExecuteWithOutput("adb devices", withSerial:false);
            if (String.IsNullOrWhiteSpace(ret))
            {
                MessageBox.Show("刷新失败");
                return;
            }
            string[] lines = ret.Split('\n');
            List<string> deviceList = new List<string>();
            bool afterList = false;
            for (int i = 0; i < lines.Length; i++)
            {
                //Console.WriteLine(lines[i]);
                string line = lines[i].Replace("\r", "");
                if (line.Equals("List of devices attached"))
                {
                    afterList = true;
                    continue;
                }
                if (!afterList)
                {
                    continue;
                }
                int idx = line.IndexOf("\t");
                if (idx <= 0 || idx >= line.Length)
                {
                    continue;
                }
                string device_id = line.Substring(0, idx);
                string device_state = line.Substring(idx + 1);
                Console.WriteLine(device_id + "  " + device_state);
                deviceList.Add(device_id);
            }
            if (deviceList.Count <= 0)
            {
                cb_slt_devices.Items.Clear();
                SelectedDevice = "";
            }
            else
            {
                bool change = true;
                foreach (var item in deviceList)
                {
                    if (item.Equals(cb_slt_devices.Text.ToString()))
                    {
                        change = false;
                        break;
                    }
                }
                string temp = cb_slt_devices.Text.ToString();
                cb_slt_devices.Items.Clear();
                cb_slt_devices.Items.AddRange(deviceList.ToArray());
                if (change)
                {
                    cb_slt_devices.SelectedIndex = 0;
                }
                else
                {
                    cb_slt_devices.Text = temp;
                }
                if (deviceList.Count == 1)
                {
                    SelectedDevice = "";
                }
                else
                {
                    SelectedDevice = cb_slt_devices.Text.ToString();
                }
            }
        }

        private void btn_disconnect_wifi_debug_Click(object sender, EventArgs e)
        {
            string slt_device = cb_slt_devices.Text.ToString();
            if (slt_device != null && slt_device.Length > 0 && slt_device.Contains(":"))
            {
                string ret = ExecuteWithOutput("adb disconnect " + slt_device);
                if (ret != null && ret.ToLower().Contains("disconnected"))
                {
                    MessageBox.Show("断开成功");
                }
                else
                {
                    MessageBox.Show("断开失败\r\n" + ret);
                }
            }
            btn_refresh.PerformClick();
        }

        private void btn_set_wifi_debug_port_Click(object sender, EventArgs e)
        {
            string ret = ExecuteWithOutput("adb tcpip " + wifi_debug_port);
            if (ret != null && ret.ToLower().Contains("restarting"))
            {
                MessageBox.Show("设置成功");
            }
            else
            {
                MessageBox.Show("设置失败\r\n" + ret);
            }
        }

        private void btn_wifi_debug_Click(object sender, EventArgs e)
        {
            Form_wifi_debug wifi_debug = new Form_wifi_debug();
            wifi_debug.ShowDialog();
        }

        private void btn_restart_adb_Click(object sender, EventArgs e)
        {
            Execute("adb kill-server");
            //Execute("adb start-server");
        }

        private void btn_open_cmd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe");
        }

        private void btn_send_cmd_Click(object sender, EventArgs e)
        {
            string cmd = tb_cmd.Text;
            if (String.IsNullOrWhiteSpace(cmd))
            {
                MessageBox.Show("请输入命令！");
                return;
            }
            ExecuteWithOutput(cmd);
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            //选择文件
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择待安装APK文件";
            dialog.Filter = "所有文件(*.apk)|*.apk";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                tb_install_path.Text = file;
                string ret = ExecuteWithOutput("adb install " + file);
                if (ret != null && ret.ToLower().Contains("success"))
                {
                    MessageBox.Show("安装成功");
                }
                else
                {
                    MessageBox.Show("安装失败\r\n" + ret);
                }
            }
        }

        private void btn_uninstall_Click(object sender, EventArgs e)
        {
            string uninstall_pkg = tb_uninstall_pkg.Text;
            if (string.IsNullOrWhiteSpace(uninstall_pkg))
            {
                MessageBox.Show("请先输入需要卸载的应用包名！");
                return;
            }
            string ret = ExecuteWithOutput("adb uninstall " + uninstall_pkg);
            if (ret != null && ret.ToLower().Contains("success"))
            {
                MessageBox.Show("卸载成功");
            }
            else
            {
                MessageBox.Show("卸载失败\r\n" + ret);
            }
        }

        private void btn_install_list_Click(object sender, EventArgs e)
        {
            // adb shell pm list packages
            string ret = ExecuteWithOutput("adb shell pm list packages");
            tb_apm_show.Text = ret;
        }

        private void btn_system_feature_list_Click(object sender, EventArgs e)
        {
            // adb shell pm list features
            string ret = ExecuteWithOutput("adb shell pm list features");
            tb_apm_show.Text = ret;
        }

        private void btn_system_lib_list_Click(object sender, EventArgs e)
        {
            // adb shell pm list libraries
            string ret = ExecuteWithOutput("adb shell pm list libraries");
            tb_apm_show.Text = ret;
        }

        private void btn_permission_groups_Click(object sender, EventArgs e)
        {
            // adb shell pm list permission-groups
            string ret = ExecuteWithOutput("adb shell pm list permission-groups");
            tb_apm_show.Text = ret;
        }

        private void btn_permission_list_Click(object sender, EventArgs e)
        {
            // adb shell pm list permissions
            string ret = ExecuteWithOutput("adb shell pm list permissions");
            tb_apm_show.Text = ret;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            // adb shell pm list users
            string ret = ExecuteWithOutput("adb shell pm list users");
            tb_apm_show.Text = ret;
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            Execute("adb shell reboot -p");
        }

        private void btn_reboot_Click(object sender, EventArgs e)
        {
            Execute("adb reboot");
        }

        private void btn_recovery_Click(object sender, EventArgs e)
        {
            Execute("adb reboot recovery");
        }

        private void btn_fastboot_Click(object sender, EventArgs e)
        {
            Execute("adb reboot bootloader");
        }

        private void btn_autodloader_Click(object sender, EventArgs e)
        {
            Execute("adb reboot autodloader");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 4");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 3");
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 82");
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 187");
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 26");
        }

        private void btn_volume_plus_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 24");
        }

        private void btn_volume_down_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 25");
        }

        private void btn_volume_off_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 164");
        }

        private void btn_take_photo_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 27");
        }

        private void btn_evoke_assistant_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 231");
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 85");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 86");
        }

        private void btn_prev_song_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 88");
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 126");
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 127");
        }

        private void btn_next_song_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 87");
        }

        private void btn_brightness_plus_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 221");
        }

        private void btn_brightness_down_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 220");
        }

        private void btn_sleep_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 223");
        }

        private void btn_light_on_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 224");
        }

        private void btn_hang_up_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 6");
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 176");
        }

        private void btn_address_list_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 207");
        }

        private void btn_call_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 5");
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 64");
        }

        private void btn_music_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 209");
        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 208");
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            Execute("adb shell input keyevent 210");
        }

        private void GetDeviceInfo()
        {
            StringBuilder sb = new StringBuilder();
            string ret = ExecuteWithOutput("adb shell getprop ro.product.brand", isChild: true);
            sb.Append("品牌：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell getprop ro.product.model", isChild: true);
            sb.Append("型号：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell getprop ro.product.name", isChild: true);
            sb.Append("设备名：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell getprop ro.build.version.sdk", isChild: true);
            sb.Append("SDK 版本：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell getprop ro.product.board", isChild: true);
            sb.Append("处理器型号：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell wm size", isChild: true);
            sb.Append("分辨率：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell wm density", isChild: true);
            sb.Append("屏幕密度：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell settings get secure android_id", isChild: true);
            sb.Append("Android ID：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell getprop ro.build.version.release", isChild: true);
            sb.Append("Android 版本：" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell ifconfig", isChild: true);
            sb.Append("网卡：\r\n" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell cat /proc/cpuinfo", isChild: true);
            sb.Append("CPU信息：\r\n" + ret + "\r\n");
            ret = ExecuteWithOutput("adb shell cat /system/build.prop", isChild: true);
            sb.Append("所有属性：\r\n" + ret + "\r\n");
            deviceInfoThreadRunning = false;
            Action action = () =>
            {
                tb_device_info.Text = sb.ToString();
            };
            Invoke(action);
                ;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                if (!deviceInfoThreadRunning)
                {
                    deviceInfoThreadRunning = true;
                    //开启线程
                    deviceInfoThread = new Thread(GetDeviceInfo);
                    deviceInfoThread.Start();
                }
            }
        }

        public void Execute(string command, bool withSerial = true, bool isChild = false)
        {
            //BeforeExecute.Invoke(null, EventArgs.Empty);

            if (String.IsNullOrWhiteSpace(SelectedDevice) || withSerial == false)
            {
                CmdTools.Execute(command);
                printAdbLogCommand(command, isChild);
            }
            else if (command.StartsWith("adb ", StringComparison.CurrentCultureIgnoreCase))
            {
                string cmd = ReplaceFirstOccurrence(command, "adb ", "adb -s " + SelectedDevice + " ");
                CmdTools.Execute(cmd);
                printAdbLogCommand(cmd, isChild);
            }
            else
            {
                CmdTools.Execute(command);
                printAdbLogCommand(command, isChild);
            }
        }

        private string ExecuteWithOutput(string command, bool withSerial = true, bool isChild = false)
        {
            if (command == null)
            {
                return null;
            }
            command = command.Trim();
            string arguments;
            if (command.StartsWith("adb "))
            {
                arguments = command.Substring(4, command.Length - 4);
                return ExecuteWithOutput("adb", arguments.Trim(), withSerial, isChild);
            }
            else
            {
                return ExecuteWithOutput("adb", command, withSerial, isChild);
            }
        }

        private string ExecuteWithOutput(string fileName, string arguments, bool withSerial = true, bool isChild = false)
        {
            if (String.IsNullOrWhiteSpace(SelectedDevice) || withSerial == false)
            {
                printAdbLogCommand(fileName + " " + arguments, isChild);
                string ret = CmdTools.GetOutput(fileName, arguments);
                printAdbLogOutput(ret, isChild);
                return ret;
            }
            else
            {
                arguments = "-s " + SelectedDevice + " " + arguments;
                printAdbLogCommand(fileName + " " + arguments, isChild);
                string ret = CmdTools.GetOutput(fileName, arguments);
                printAdbLogOutput(ret, isChild);
                return ret;
            }
        }

        private string ReplaceFirstOccurrence(string Source, string Find, string Replace)
        {
            // Thanks to Tim Trott
            // https://lonewolfonline.net/replace-first-occurrence-string/
            int Place = Source.IndexOf(Find);
            string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
            return result;
        }

        private void printAdbLogCommand(string cmd, bool isChild = false)
        {
            if (isChild)
            {
                Action action = () =>
                {
                    printAdbLog(DateTime.Now.ToString() + " >> " + cmd);
                };
                Invoke(action);
            }
            else
            {
                printAdbLog(DateTime.Now.ToString() + " >> " + cmd);
            }
        }

        private void printAdbLogOutput(string output, bool isChild = false)
        {
            if (isChild)
            {
                Action action = () =>
                {
                    printAdbLog(output);
                };
                Invoke(action);
            }
            else
            {
                printAdbLog(output);
            }
        }

        private void printAdbLog(string text)
        {
            tb_cmd_log.Text += text + "\r\n";
        }

    }
}

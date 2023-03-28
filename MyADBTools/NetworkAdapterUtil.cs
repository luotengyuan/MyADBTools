using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

namespace MyADBTools
{
    class NetworkAdapterUtil
    {

        /// <summary>
        /// 获取所有适配器类型，适配器被禁用则不能获取到
        /// </summary>
        /// <returns></returns>
        public List<NetworkAdapter> GetAllNetworkAdapters() //如果适配器被禁用则不能获取到
        {
            IEnumerable<NetworkInterface> adapters = NetworkInterface.GetAllNetworkInterfaces(); //得到所有适配器  //获取本地计算机上网络接口的对象
            return GetNetworkAdapters(adapters);

        }

        /// <summary>
        /// 根据条件获取IP地址集合，
        /// </summary>
        /// <param name="adapters">网络接口地址集合</param>
        /// <param name="adapterTypes">网络连接状态，如,UP,DOWN等</param>
        /// <returns></returns>
        private List<NetworkAdapter> GetNetworkAdapters(IEnumerable<NetworkInterface> adapters, params NetworkInterfaceType[] networkInterfaceTypes)
        {
            List<NetworkAdapter> adapterList = new List<NetworkAdapter>();
            int serial = 0;

            foreach (NetworkInterface adapter in adapters)
            {
                if (networkInterfaceTypes.Length <= 0) //如果没传可选参数，就查询所有
                {
                    if (adapter != null)
                    {
                        NetworkAdapter adp = SetNetworkAdapterValue(serial, adapter);
                        if (adp != null)
                        {
                            serial++;
                            adapterList.Add(adp);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else //过滤查询数据
                {
                    foreach (NetworkInterfaceType networkInterfaceType in networkInterfaceTypes)
                    {
                        if (adapter.NetworkInterfaceType.ToString().Equals(networkInterfaceType.ToString()))
                        {
                            NetworkAdapter adp = SetNetworkAdapterValue(serial, adapter);
                            if (adp != null)
                            {
                                serial++;
                                adapterList.Add(adp);
                            }
                            break; //退出当前循环
                        }
                    }
                }
            }
            return adapterList;
        }

        /// <summary>
        /// 3. 获取所有适配器
        /// 设置网络适配器信息
        /// </summary>
        /// <param name="serial"></param>
        /// <param name="adapter"></param>
        /// <returns></returns>
        private NetworkAdapter SetNetworkAdapterValue(int serial, NetworkInterface adapter)
        {
            if (adapter == null)
            {
                return null;
            }
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("描述：" + adapter.Description);
            Console.WriteLine("标识符：" + adapter.Id);
            Console.WriteLine("名称：" + adapter.Name);
            Console.WriteLine("类型：" + adapter.NetworkInterfaceType);
            Console.WriteLine("速度：" + adapter.Speed * 0.001 * 0.001 + "M");
            Console.WriteLine("操作状态：" + adapter.OperationalStatus);
            Console.WriteLine("MAC 地址：" + adapter.GetPhysicalAddress());

            // 格式化显示MAC地址                
            PhysicalAddress pa = adapter.GetPhysicalAddress();//获取适配器的媒体访问（MAC）地址
            byte[] bytes = pa.GetAddressBytes();//返回当前实例的地址
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));//以十六进制格式化
                if (i != bytes.Length - 1)
                {
                    sb.Append("-");
                }
            }
            Console.WriteLine("MAC 地址：" + sb);

            IPInterfaceProperties ip = adapter.GetIPProperties();     //IP配置信息
            if (ip != null)
            {
                if (ip.UnicastAddresses != null)
                {
                    foreach (var item in ip.UnicastAddresses)
                    {
                        //判断是否为ipv4
                        if (item.Address.AddressFamily != AddressFamily.InterNetwork)
                            continue;
                        Console.WriteLine("IP 地址：" + item.Address);   //IP地址
                        Console.WriteLine("子网掩码：" + item.IPv4Mask);  //子网掩码
                    }
                }
                if (ip.GatewayAddresses != null)
                {
                    foreach (var item in ip.GatewayAddresses)
                    {
                        Console.WriteLine("默认网关：" + item.Address);   //默认网关
                    }
                }
                if (ip.DnsAddresses != null)
                {
                    foreach (var item in ip.DnsAddresses)
                    {
                        Console.WriteLine("DNS服务器地址：" + item);       //首选DNS服务器地址
                    }
                }
            }
            Console.WriteLine("===============================\n");

            NetworkAdapter networkAdapter = new NetworkAdapter();
            try
            {
                networkAdapter.Serial = serial;
                if (adapter != null)
                {
                    networkAdapter.Description = adapter.Description;
                    networkAdapter.Name = adapter.Name;
                    networkAdapter.NetworkInterfaceType = adapter.NetworkInterfaceType;
                    networkAdapter.Speed = adapter.Speed; //速度 byte
                    networkAdapter.MacAddress = adapter.GetPhysicalAddress(); //物理地址集合
                    networkAdapter.NetworkInterfaceID = adapter.Id;//网络适配器标识符
                }
                IPInterfaceProperties ips = adapter.GetIPProperties();
                if (ips != null)
                {
                    networkAdapter.Getwaryes = ips.GatewayAddresses; //网关地址集合
                    networkAdapter.IPAddresses = ips.UnicastAddresses; //IP地址集合
                    networkAdapter.DhcpServerAddresses = ips.DhcpServerAddresses;//DHCP地址集合
                    networkAdapter.IsDhcpEnabled = ips.GetIPv4Properties() == null ? false : ips.GetIPv4Properties().IsDhcpEnabled; //是否启用DHCP服务

                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();//获取IPInterfaceProperties实例 
                    networkAdapter.DnsAddresses = adapterProperties.DnsAddresses; //获取并显示DNS服务器IP地址信息 集合
                }
            }
            catch (Exception ext)
            {
                Console.WriteLine(ext.ToString());
            }
            return networkAdapter;
        }



        /// <summary>
        /// 启用所有适配器
        /// </summary>
        /// <returns></returns>
        public void EnableAllAdapters()
        {
            // ManagementClass wmi = new ManagementClass("Win32_NetworkAdapter");
            // ManagementObjectCollection moc = wmi.GetInstances();
            System.Management.ManagementObjectSearcher moc = new System.Management.ManagementObjectSearcher("Select * from Win32_NetworkAdapter where NetEnabled!=null ");
            foreach (System.Management.ManagementObject mo in moc.Get())
            {
                //if (!(bool)mo["NetEnabled"])
                //  continue;
                string capation = mo["Caption"].ToString();
                string descrption = mo["Description"].ToString();
                mo.InvokeMethod("Enable", null);
            }

        }

        /// <summary>
        /// 禁用所有适配器
        /// </summary>
        public void DisableAllAdapters()
        {
            // ManagementClass wmi = new ManagementClass("Win32_NetworkAdapter");
            // ManagementObjectCollection moc = wmi.GetInstances();
            System.Management.ManagementObjectSearcher moc = new System.Management.ManagementObjectSearcher("Select * from Win32_NetworkAdapter where NetEnabled!=null ");
            foreach (System.Management.ManagementObject mo in moc.Get())
            {
                //if ((bool)mo["NetEnabled"])
                //  continue;
                string capation = mo["Caption"].ToString();
                string descrption = mo["Description"].ToString();
                mo.InvokeMethod("Disable", null);
            }

        }

    }
}

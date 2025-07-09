using System;
using System.Net;
using System.Net.Sockets;

namespace Tugasucp1
{
    internal class koneksi
    {

        public static string ConnectionString
        {
            get
            {
                string serverName = "DESKTOP-IPMTL32";
                string databaseName = "DonasiBarangBekas";
                return $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            }
        }


        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("tidak ada alamat IP yang ditemukan!");
        }
    }
}

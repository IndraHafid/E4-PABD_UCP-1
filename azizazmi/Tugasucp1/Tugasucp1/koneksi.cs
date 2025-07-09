using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tugasucp1
{
    internal class koneksi
    {
        public string connectionString()
        {
            string connectStr = "";
            try
            {
                string localIP = GetLocalIPAddress(); //mendeklarasikan ipaddress
                connectStr = $"Server={localIP};Initial Catalog=DonasiBarangBekas1;" +
                    $"user id=sa;password=@@SuguruMyLove777; trustservercertificate=true;";
                return connectStr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            //try
            //{
            //    string serverName = "LAPTOP-97JFDRMG\\AZIZAH_A_AZMI";
            //    string databaseName = "DonasiBarangBekas";

            //    string connectStr = $"Data Source={serverName};Initial Catalog={databaseName};user id=sa;password=@@SuguruMyLove777;";
            //    return connectStr;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //    return string.Empty;
            //}
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

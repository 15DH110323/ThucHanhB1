﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace THBuoi1
{
    class Program
    {
        ///
        /// Gets IP addresses of the local machine
        ///
        static void Main(string[] args)
        {
            //BaiTap1
            String strHostName = Dns.GetHostName();
            Console.WriteLine("HostName: {0} ", strHostName);

            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP {0}: {1}", ++nIP, ipaddress.ToString());
            }
            //BaiTap2

            Console.Write("Hostname/IP: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Hostname: {0}", e.HostName);

            foreach (string s in e.Aliases)
                Console.WriteLine("Alias: {0} \n", s);

            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("IP: {0}", i);
        }
    }
}

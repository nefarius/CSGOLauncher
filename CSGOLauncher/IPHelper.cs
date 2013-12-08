﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;

namespace CSGOLauncher
{
    public static class IPHelper
    {
        public static string PrivateIpAddress
        {
            get
            {
                return Dns.GetHostEntry(Environment.MachineName).AddressList.Where(i => i.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();
            }
        }

        public static string PublicIpAddress
        {
            get
            {
                string content;
                var request = (HttpWebRequest)WebRequest.Create("http://checkip.dyndns.org/");
                Regex ip = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");

                request.UserAgent = "curl"; // this simulate curl Linux command
                request.Method = "GET";

                using (WebResponse response = request.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        content = reader.ReadToEnd();
                    }
                }

                return ip.Matches(content)[0].ToString();
            }
        }
    }
}

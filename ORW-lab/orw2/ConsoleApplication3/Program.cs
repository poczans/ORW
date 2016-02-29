using System;
using System.Threading;
using System.Net;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            using (WebClient wb = new WebClient())
            {
                try
                {
                    wb.Proxy = null;
                    wb.DownloadString("http://www.onet.pl");
                    foreach (string name in wb.ResponseHeaders.Keys)
                    {
                        Console.WriteLine(name + "=" + wb.ResponseHeaders[name]);
                    }
                }
                catch (WebException e)
                {
                    Console.WriteLine(e.Status);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fivem_ip_grabber
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Fivem IP Grabber by goldblack";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Give me server url address: ");
            string urlinput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Getting server ip address...");
            Thread.Sleep(3000);
            getIP(urlinput);
        }
        static void getIP(string urlinput)
        {
            var url = "https://" + urlinput;
            Uri myUri = new Uri(url);
            var ip = Dns.GetHostAddresses(myUri.Host)[0];
            var port = myUri.Port;

            Console.WriteLine();
            Console.WriteLine("Server ip address: " + ip + port);
            Console.ReadKey(true);
        }
    }
}

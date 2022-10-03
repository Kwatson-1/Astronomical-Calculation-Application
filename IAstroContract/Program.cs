using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroContract), new Uri[]
            {
                new Uri("net.pipe://localhost/")
            }))
            {
                host.AddServiceEndpoint(typeof(IAstroContract),
                new NetNamedPipeBinding(), "AstroServer");
                host.Open();
                Console.WriteLine("Service is available. " + "Press <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }

            //string address = "net.pipe://localhost/AstroServer";
            //ServiceHost serviceHost = new ServiceHost(typeof(AstroContract));
            //NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            //serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            //serviceHost.Open();
            //Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
            //Console.ReadLine();
            //serviceHost.Close();
        }

    }
}

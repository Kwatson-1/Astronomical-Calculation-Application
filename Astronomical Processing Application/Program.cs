using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Astronomical_Processing_Application
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AstronomcalProcessingApplication());

            Console.WriteLine("Client Started");
            string address = "net.pipe://localhost/AstroServer";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            //Console.WriteLine("Client Started");
            //ChannelFactory<IAstroContract> pipeFactory =
            //new ChannelFactory<IAstroContract>(
            //new NetNamedPipeBinding(),
            //new EndpointAddress("net.pipe://localhost/AstroServer"));
            //IAstroContract pipeProxy = pipeFactory.CreateChannel();
            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    Console.WriteLine("pipe: " + pipeProxy.StarVelocity(str));

            //}
        }
    }
}

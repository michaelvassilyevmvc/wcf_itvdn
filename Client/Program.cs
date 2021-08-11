using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            Uri address = new Uri("http://localhost:4050/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(address);
            ChannelFactory<IContract> channelFactory = new ChannelFactory<IContract>(binding, endpoint);
            IContract channel = channelFactory.CreateChannel();
            channel.Say("It a live!!!!");
            Console.ReadKey();


        }
    }
}

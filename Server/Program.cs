using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            Uri address = new Uri("http://localhost:4050/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            Type contract = typeof(IContract);

            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Ожидание сообщения от клиента");
            Console.ReadKey();


            Console.WriteLine("Перед закрытием host");
            host.Close();
        }
    }
}

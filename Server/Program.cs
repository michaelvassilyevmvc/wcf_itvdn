using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            Uri uri = new Uri("http://localhost:4050/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            Type contract = typeof(IContract);

            ServiceHost host = new ServiceHost(contract, uri);
            host.AddServiceEndpoint(contract, binding, uri);
            host.Open();

            Console.WriteLine("Ожидание сообщения от клиента");
            Console.ReadKey();


            Console.WriteLine("Перед закрытием host");
            host.Close();
        }
    }
}

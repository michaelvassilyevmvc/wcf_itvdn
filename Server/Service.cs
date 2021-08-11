using System;

namespace Server
{
    public class Service : IContract
    {
        public void Say(string input)
        {
            Console.WriteLine($"Клинет прислал сообщение {input}");
        }
    }
}

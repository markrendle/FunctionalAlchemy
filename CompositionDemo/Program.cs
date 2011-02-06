using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CompositionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            service.ReverseStringCompleted += service_ReverseStringCompleted;
            service.ReverseStringAsync("Banana");
            service.ReverseStringAsync("Banana");

            Console.Write("Waiting...");
            Console.ReadLine();
        }

        static void service_ReverseStringCompleted(object sender, AsyncCompletedEventArgs<string> e)
        {
            Console.WriteLine(e.Result);
        }
    }
}

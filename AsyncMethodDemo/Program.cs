using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncMethodWpf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling service...");
            var service = new Service();
            Console.WriteLine("Service returned: " + service.ReverseString("Banana"));
        }
    }
}

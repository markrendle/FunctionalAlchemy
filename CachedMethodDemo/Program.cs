using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CachedMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new TweakedService();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Calling service...");
                Console.WriteLine("Service returned: " + service.ReverseString("Banana"));
            }
        }
    }
}

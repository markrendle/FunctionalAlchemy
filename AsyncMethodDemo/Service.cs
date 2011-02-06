using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncMethodWpf
{
    public class Service
    {
        public string ReverseString(string input)
        {
            Thread.Sleep(2000);
            return new String(input.Reverse().ToArray());
        }
    }
}

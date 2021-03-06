﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TupleTryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var average = SomeStrings()
                .Select(Int32Ex.TryParse)
                .Where((success, i) => success)
                .Select((success, i) => i)
                .Average();

            Console.WriteLine(average);
        }

        static IEnumerable<string> SomeStrings()
        {
            return "What do you get if you multiply 6 by 9 ? 42 ?".Split(' ');
        }
    }
}

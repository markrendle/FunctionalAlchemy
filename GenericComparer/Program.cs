using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericComparerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var point in Points()
                .Sort((first,second) => (first.X * first.Y).CompareTo(second.X * second.Y)))
            {
                Console.WriteLine("{0},{1}", point.X, point.Y);
            }
        }

        static IEnumerable<Point> Points()
        {
            yield return new Point { X = 25, Y = 25};
            yield return new Point { X = 100, Y = 100 };
            yield return new Point { X = 50, Y = 50};
            yield return new Point { X = 10, Y = 10 };
        }
    }
}

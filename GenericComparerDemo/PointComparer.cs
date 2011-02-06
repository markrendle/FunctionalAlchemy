using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericComparerDemo
{
    public class PointComparer : IComparer<Point>
    {
        public int Compare(Point first, Point second)
        {
            return (first.X * first.Y).CompareTo(second.X * second.Y);
        }
    }
}

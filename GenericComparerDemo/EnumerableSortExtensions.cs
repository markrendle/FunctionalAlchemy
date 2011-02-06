using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericComparerDemo
{
    public static class EnumerableSortExtensions
    {
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> source, Func<T, T, int> comparer)
        {
            var genericComparer = new GenericComparer<T>(comparer);
            return source.OrderBy(item => item, genericComparer);
        }
    }
}

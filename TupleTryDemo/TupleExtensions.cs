using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TupleTryDemo
{
    public static class TupleExtensions
    {
        public static void Do<T1, T2>(this Tuple<T1, T2> tuple, Action<T1, T2> action)
        {
            action(tuple.Item1, tuple.Item2);
        }

        public static IEnumerable<Tuple<T1,T2>> Where<T1, T2>(this IEnumerable<Tuple<T1, T2>> source, Func<T1, T2, bool> predicate)
        {
            return source.Where((tuple) => predicate(tuple.Item1, tuple.Item2));
        }

        public static IEnumerable<TResult> Select<T1, T2, TResult>(this IEnumerable<Tuple<T1, T2>> source, Func<T1, T2, TResult> selector)
        {
            return source.Select((tuple) => selector(tuple.Item1, tuple.Item2));
        }
    }
}

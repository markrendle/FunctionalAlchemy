using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericComparerDemo
{
    class GenericComparer<T> : IComparer<T>
    {
        private readonly Func<T,T,int> _func;

        public GenericComparer(Func<T, T, int> func)
        {
            _func = func;
        }
        public int Compare(T x, T y)
        {
            return _func(x, y);
        }
    }
}

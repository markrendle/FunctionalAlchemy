using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqyGoodness
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = new MyEnumerable();
            string.IsNullOrEmpty("");
            var n = Enumerable.Count(my);
        }
    }

    class MyEnumerable : IEnumerable<object>
    {
        public IEnumerator<object> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

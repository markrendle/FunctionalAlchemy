using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TupleTryDemo
{
    public static class Int32Ex
    {
        public static Tuple<bool, int> TryParse(string value)
        {
            int result;
            bool success = Int32.TryParse(value, out result);
            return Tuple.Create(success, result);
        }
    }
}

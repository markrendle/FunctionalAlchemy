using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CachedMethodDemo
{
    public class TweakedService
    {
        private readonly Func<string, string> _cachedReverseString;

        public TweakedService()
        {
            _cachedReverseString = MethodTweaker.MakeCached<string, string>(ReverseStringImpl);
        }

        public Func<string, string> ReverseString { get { return _cachedReverseString; } }

        //public string ReverseString(string input)
        //{
        //    if (input == null) throw new ArgumentNullException("input");
        //    return _cachedReverseString(input);
        //}

        private static string ReverseStringImpl(string input)
        {
            Thread.Sleep(2000);
            return new string(input.Reverse().ToArray());
        }
    }
}

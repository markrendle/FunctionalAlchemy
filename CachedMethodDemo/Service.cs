using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CachedMethodDemo
{
    public class Service
    {
        public string ReverseString(string input)
        {
            if (input == null) throw new ArgumentNullException("input");
            if (!_cache.ContainsKey(input))
            {
                lock (_sync)
                {
                    if (!_cache.ContainsKey(input))
                    {
                        _cache.Add(input, ReverseStringImpl(input));
                    }
                }
            }

            return _cache[input];
        }
        private readonly Dictionary<string, string> _cache =
            new Dictionary<string, string>();
        private readonly object _sync = new object();

        private static string ReverseStringImpl(string input)
        {
            Thread.Sleep(2000);
            return new string(input.Reverse().ToArray());
        }
    }
}

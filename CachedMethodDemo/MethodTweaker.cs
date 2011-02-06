using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;

namespace CachedMethodDemo
{
    public static class MethodTweaker
    {
        public static Func<T, TResult> MakeCached<T, TResult>(Func<T, TResult> original)
        {
            var cache = new ConcurrentDictionary<T, TResult>();
            var sync = new object();

            return (arg) =>
            {
                return cache.GetOrAdd(arg, a => original(a));
            }; 
        }
    }
}

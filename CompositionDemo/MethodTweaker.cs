using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CompositionDemo
{
    public static class MethodTweaker
    {
        public static Func<T, TResult> MakeCached<T, TResult>(Func<T, TResult> func)
        {
            var cache = new Dictionary<T, TResult>();
            var sync = new object();

            return (arg) =>
                {
                    if (!cache.ContainsKey(arg))
                    {
                        lock (sync)
                        {
                            if (!cache.ContainsKey(arg))
                            {
                                cache.Add(arg, func(arg));
                            }
                        }
                    }
                    return cache[arg];
                };
        }

        public static Action<T> MakeAsync<T, TResult>(Func<T, TResult> func, Func<EventHandler<AsyncCompletedEventArgs<TResult>>> handler, object sender)
        {
            Action<T> async = (arg) =>
                {
                    try
                    {
                        var result = func(arg);
                        handler()(sender, new AsyncCompletedEventArgs<TResult>(result, null));
                    }
                    catch (Exception ex)
                    {
                        handler()(sender, new AsyncCompletedEventArgs<TResult>(ex, null));
                    }
                };

            return (arg) =>
                {
                    async.BeginInvoke(arg, (iar) => async.EndInvoke(iar), null);
                };
        }

        public static Func<T, TResult> AddTracing<T, TResult>(Func<T, TResult> func, Func<string> traceMessage)
        {
            return (arg) =>
                {
                    Trace.WriteLine(traceMessage());
                    return func(arg);
                };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiExceptionWpf
{
    class TryCatch
    {
        private Action _action;

        private TryCatch(Action action)
        {
            _action = action;
        }

        public static TryCatch Try(Action action)
        {
            return new TryCatch(action);
        }

        public static TryCatch TryUsing<T>(Func<T> resourceCreator, Action<T> action)
            where T : IDisposable
        {
            return new TryCatch(() =>
                       {
                           using (var resource = resourceCreator())
                           {
                               action(resource);
                           }
                       });
        }

        public static TryCatch TryUsing<T>(T resource, Action<T> action)
            where T : IDisposable
        {
            return new TryCatch(() =>
            {
                using (resource)
                {
                    action(resource);
                }
            });
        }

        public void Catch<T1, T2>(Action<Exception> handler)
            where T1 : Exception
            where T2 : Exception
        {
            try { _action(); }
            catch (T1 ex) { handler(ex); }
            catch (T2 ex) { handler(ex); }
        }

        public void Catch<T1, T2, T3>(Action<Exception> handler)
            where T1 : Exception
            where T2 : Exception
            where T3 : Exception
        {
            try
            {
                Catch<T1, T2>(handler);
            }
            catch (T3 ex) { handler(ex); }
        }

        public void Catch<T1, T2, T3, T4>(Action<Exception> handler)
            where T1 : Exception
            where T2 : Exception
            where T3 : Exception
            where T4 : Exception
        {
            try
            {
                Catch<T1, T2, T3>(handler);
            }
            catch (T4 ex) { handler(ex); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsyncMethodWpf
{
    public class AsyncCompletedEventArgs<T> : AsyncCompletedEventArgs
    {
        private readonly T _result;

        public AsyncCompletedEventArgs(T result, object userState) : base(null, false, userState)
        {
            _result = result;
        }

        public AsyncCompletedEventArgs(Exception ex, object userState)
            : base(ex, false, userState)
        {
            _result = default(T);
        }

        public T Result
        {
            get { return _result; }
        } 

    }
}

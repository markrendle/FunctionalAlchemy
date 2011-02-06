using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncMethodWpf
{
    public class Service
    {
        private readonly Action<string> _asyncReverseString;
        public Service()
        {
            _asyncReverseString = MethodTweaker.MakeAsync<string,string>
                (ReverseStringImpl,
                () => ReverseStringCompleted,
                this);
        }

        public string ReverseString(string input)
        {
            if (input == null) throw new ArgumentNullException("input");
            return ReverseStringImpl(input);
        }

        public void ReverseStringAsync(string input)
        {
            _asyncReverseString(input);
        }

        public event EventHandler<AsyncCompletedEventArgs<string>> ReverseStringCompleted;

        private static string ReverseStringImpl(string input)
        {
            Thread.Sleep(5000);
            return new String(input.Reverse().ToArray());
        }
    }
}

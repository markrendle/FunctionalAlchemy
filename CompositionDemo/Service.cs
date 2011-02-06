using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CompositionDemo
{
    public class Service
    {
        readonly Action<string> _asyncMethod;

        public Service()
        {
            _asyncMethod = MethodTweaker.MakeAsync<string, string>(
                MethodTweaker.MakeCached<string, string>(
                ReverseString),
                () => ReverseStringCompleted, this);
        }

        public string ReverseString(string input)
        {
            Thread.Sleep(2000);
            return new String(input.Reverse().ToArray());
        }

        public void ReverseStringAsync(string input)
        {
            _asyncMethod(input);
        }

        public event EventHandler<AsyncCompletedEventArgs<string>> ReverseStringCompleted;
    }
}

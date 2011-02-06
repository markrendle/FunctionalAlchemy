using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlerDemo
{
    public class StringListEventArgs : EventArgs
    {
        private readonly IList<string> _strings;

        public StringListEventArgs(IEnumerable<string> strings)
        {
            _strings = strings.ToList();
        }

        public IList<string> Strings
        {
            get { return _strings; }
        } 
    }
}

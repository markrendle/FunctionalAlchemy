﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlerDemo
{
    public class StringLister
    {
        public void ListStrings(IEnumerable<string> strings)
        {
            StringListed.Raise(this, () => new StringListEventArgs(strings));
        }

        public event EventHandler<StringListEventArgs> StringListed;
    }
}

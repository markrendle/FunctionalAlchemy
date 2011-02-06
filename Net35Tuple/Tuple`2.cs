﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class Tuple<T1,T2>
    {
        private readonly T1 _item1;
        private readonly T2 _item2;

        public Tuple(T1 item1, T2 item2)
        {
            _item1 = item1;
            _item2 = item2;
        }

        public T1 Item1
        {
            get { return _item1; }
        }

        public T2 Item2
        {
            get { return _item2; }
        }
    }
}

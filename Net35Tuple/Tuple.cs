using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net35Tuple
{
    /// <summary>
    /// Static helper class for creating Tuple instances with type inference.
    /// </summary>
    public static class Tuple
    {
        /// <summary>
        /// Creates a <see cref="Tuple`2"/>. Provides type inference not available on the constructor.
        /// </summary>
        /// <typeparam name="T1">The type of the first item.</typeparam>
        /// <typeparam name="T2">The type of the second item.</typeparam>
        /// <param name="item1">The first item.</param>
        /// <param name="item2">The second item.</param>
        /// <returns></returns>
        public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
        {
            return new Tuple<T1, T2>(item1, item2);
        }

        /// <summary>
        /// Creates a <see cref="Tuple`3"/>. Provides type inference not available on the constructor.
        /// </summary>
        /// <typeparam name="T1">The type of the first item.</typeparam>
        /// <typeparam name="T2">The type of the second item.</typeparam>
        /// <typeparam name="T3">The type of the third item.</typeparam>
        /// <param name="item1">The first item.</param>
        /// <param name="item2">The second item.</param>
        /// <param name="item3">The third item.</param>
        /// <returns></returns>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }
    }
}

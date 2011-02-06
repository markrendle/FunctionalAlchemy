using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlerDemo
{
    public static class EventHandlerExtensions
    {
        public static void Raise(this EventHandler handler, object sender)
        {
            if (handler != null)
            {
                handler(sender, EventArgs.Empty);
            }
        }

        public static void Raise<T>(this Delegate handler, object sender, T args)
            where T : EventArgs
        {
            if (handler != null)
            {
                handler.DynamicInvoke(sender, args);
            }
        }

        #region Lazy creation

        public static void Raise<T>(this Delegate handler, object sender, Func<T> args)
            where T : EventArgs
        {
            if (handler != null)
            {
                handler.DynamicInvoke(sender, args());
            }
        }

        #endregion
    }
}

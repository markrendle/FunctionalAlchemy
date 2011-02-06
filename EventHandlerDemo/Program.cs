using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EventHandlerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var lister = new StringLister();

            //lister.StringListed += new EventHandler<StringListEventArgs>(lister_StringListed);

            lister.ListStrings(GetStrings());
        }

        static void lister_StringListed(object sender, StringListEventArgs e)
        {
            Console.WriteLine(string.Join(" ", e.Strings));
        }

        static IEnumerable<string> GetStrings()
        {
            yield return "It";
            yield return "Was";
            yield return "A";
            yield return "Dark";
            yield return "And";
            yield return "Stormy";
            yield return "Night";

            Console.WriteLine("Yielded all my strings");
        }
    }
}

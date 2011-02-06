using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace HigherOrderDemo
{
  class Program
  {
    private static long _total;

    static void Main()
    {
      var stopwatch = Stopwatch.StartNew();
      RunLoop();
      stopwatch.Stop();
      Console.WriteLine("Working that out took: {0}", stopwatch.Elapsed);
      Console.WriteLine();
    }

    private static void RunLoop()
    {
      for (int i = 0; i < 1000; i++)
      {
        AccumulateMultiplesOfTen(i, () => new RandomNumber().Value);
      }

      Console.WriteLine("The total is {0}", _total);
      Console.WriteLine();
    }

    static void AccumulateMultiplesOfTen(int index, int value)
    {
        AccumulateMultiplesOfTen(index, () => value);
    }

    static void AccumulateMultiplesOfTen(int index, Func<int> value)
    {
      if (index % 10 == 0)
      {
        _total += value();
      }
    }
  }

  class RandomNumber
  {
    private static readonly Random Random = new Random(123456);
    private readonly int _value;

    public RandomNumber()
    {
      Thread.Sleep(1);
      _value = Random.Next();
    }

    public int Value
    {
      get { return _value; }
    }
  }
}

using System;
using System.Linq;

namespace CommandLineArgs
{
  class Program
  {
    public static void Main(string []arguments)
    {
      arguments.Reverse().ToList().ForEach(argument => {
        Console.WriteLine(argument);
      });
    }
  }
}

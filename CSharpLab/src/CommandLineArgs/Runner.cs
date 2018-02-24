using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLineArgs
{
  class Runner
  {
    public static void EntryPoint(IEnumerable<string> arguments)
    {
      arguments.Reverse().ToList().ForEach(argument => Console.WriteLine(argument));
    }
  }
}

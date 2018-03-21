using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.CommandLineArgs
{
  class Program
  {
    static void Main(string []args)
    {
      args.Reverse().ToList().ForEach(argument => Console.WriteLine(argument));
    }
  }
}

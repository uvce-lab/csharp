using System;

namespace CSharpLab.OperatorOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(new Complex(0, 0));
      Console.WriteLine(new Complex(0, 3));
      Console.WriteLine(new Complex(0, -5));
      Console.WriteLine(new Complex(4, -5));
      Console.WriteLine(new Complex(-10, -5));
    }
  }
}

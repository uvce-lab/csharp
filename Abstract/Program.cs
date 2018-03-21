using System;

namespace CSharpLab.Abstract
{
  class Program
  {
    static void Main(string[] args)
    {
      var triangle = new Circle(1);
      Console.WriteLine($"{triangle.Area():0.0000}");

      triangle = new Circle(Math.Sqrt(1/Math.PI));
      Console.WriteLine($"{triangle.Area():0.0000}");
    }
  }
}

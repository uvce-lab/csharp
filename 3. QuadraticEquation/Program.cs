using System;
using System.Linq;

namespace CSharpLab.QuadraticEquation
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a, b and c from ax² + bx + c = 0");
      var coeffiecientsInput = Console.ReadLine();

      try
      {
        var coeffiecients =
        coeffiecientsInput
        .Trim()
        .Split()
        .Select(double.Parse)
        .ToList();

        var c = coeffiecients;
        var roots = new Equation(c[0], c[1], c[2]).Roots();

        Console.WriteLine($"Roots: {roots}");
      }
      catch (Exception)
      {
        Console.WriteLine("Invalid input.");
      }
    }
  }
}
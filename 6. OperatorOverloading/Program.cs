using System;

namespace CSharpLab.OperatorOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      var firstNumber = new Complex(1.5, 4);
      var secondNumber = new Complex(100, 0);

      var result = firstNumber + secondNumber;
      Console.WriteLine("Using overloaded '+' operator on Complex objects.");
      Console.WriteLine($"({firstNumber}) + ({secondNumber}) = ({result})");
    }
  }
}

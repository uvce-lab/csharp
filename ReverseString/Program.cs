using System;

using CSharpLab.ReverseString;

namespace CSharpLab.ReverseString
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the string to reverse: ");
      var inputString = Console.ReadLine();

      Console.WriteLine($"Reversed string: {inputString.Reverse()}");
    }
  }
}

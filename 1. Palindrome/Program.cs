using System;
using System.Collections.Generic;

namespace CSharpLab.Palindrome
{
  class Program
  {
    static void Main(string []args)
    {
      Console.Write("Enter number to check palindrome: ");
      string input = Console.ReadLine();

      if (long.TryParse(input, out long convertedValue))
        Console.WriteLine($"Palindrome check: {Palindrome.Check(convertedValue)}");
      else
        Console.WriteLine("Could not convert input to a number.");
    }
  }
}

using System;

namespace Palindrome
{
  class Program
  {
    public static void Main()
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

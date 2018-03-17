using System;
using System.Linq;

namespace SecondLargest
{
  class Program
  {
    static void Main()
    {
      Console.Write("Enter the numbers: ");

      try
      {
        var numbers = Console.ReadLine().Trim();

        var secondLargest = numbers
        .Split()
        .Select(double.Parse)
        .OrderByDescending(p => p)
        .Take(2)
        .LastOrDefault();

        Console.WriteLine($"The second largest number: {secondLargest}");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}

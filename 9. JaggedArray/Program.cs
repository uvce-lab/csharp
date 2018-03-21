using System;
using System.Linq;

namespace JaggedArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the number of rows: ");
      var rows = int.Parse(Console.ReadLine());

      var jaggedArray = new double[rows][];

      for (int i = 0; i < rows; ++i)
      {
        Console.WriteLine($"Enter elements for row {i}:");
        jaggedArray[i] = Console.ReadLine()
          .Trim()
          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
          .Select(double.Parse)
          .ToArray();
      }

      Console.WriteLine("Jagged Array:");
      jaggedArray.ToList().ForEach(p => Console.WriteLine(String.Join(" ", p)));

      var sum = (from row in jaggedArray
                 from item in row
                 select item).Sum();

      Console.WriteLine($"Sum of elements in the jagged array: {sum}");
    }
  }
}

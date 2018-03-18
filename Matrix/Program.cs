using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CSharpLab.Matrix
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter rows and columns for first matrix: ");
      var first = _readArray();

      Console.WriteLine("Enter elements for Matrix A:");
      var matrixA = new Matrix(
        first[0],
        first[1],
        _readMatrix(first[0], first[1]));

      Console.Write("Enter rows and columns for first matrix: ");
      var second = _readArray();

      Console.WriteLine("Enter elements for Matrix B:");
      var matrixB = new Matrix(
        second[0],
        second[1],
        _readMatrix(second[0], second[1]));

      do
      {
        Console.Write("MENU:\n1. Display matrix A\n2. Display Matrix B\n3. Multiply matrices\n4. Exit\nEnter your choice: ");

        var choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
          case 1:
            Console.WriteLine($"Matrix A:\n{matrixA}");
            break;

          case 2:
            Console.WriteLine($"Matrix B:\n{matrixB}");
            break;

          case 3:
            try
            {
              Console.WriteLine($"A * B = \n{matrixA * matrixB}");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            break;

          case 4:
            return;

          default:
            Console.WriteLine("You entered an invalid choice.");
            break;
        }
      } while (true);

    }
    static List<uint> _readArray() =>
      Console.ReadLine()
        .Trim()
        .Split()
        .Select(uint.Parse)
        .ToList();

    static double[,] _readMatrix(uint rows, uint columns)
    {
      var matrix = new double[rows, columns];

      for (int i = 0; i < rows; ++i)
      {
        var line = Console.ReadLine()
          .Trim()
          .Split()
          .Select(double.Parse)
          .ToList();

        for (int j = 0; j < columns; ++j)
          matrix[i, j] = line[j];
      }
      return matrix;
    }
  }
}

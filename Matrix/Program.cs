using System;
using System.Numerics;

namespace CSharpLab.Matrix
{
  class Program
  {
    static void Main(string[] args)
    {
      var matrix = new Matrix(2, 3, new double[,] {
        {1, 2, 5},
        {4, 62, 4}
      });
      Console.WriteLine(matrix);
    }
  }
}

using System;

namespace CSharpLab.InterfaceArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      IShape[] shapes = new IShape[]
      {
        new Circle(),
        new Rectangle(),
      };

      foreach (IShape shape in shapes)
      {
        Console.WriteLine(shape.Name);

        shape.Input();

        Console.WriteLine($"Area: {shape.Area()}");
        Console.WriteLine($"Number of points: {shape.NumberOfPoints()}{Environment.NewLine}");
      }
    }
  }
}

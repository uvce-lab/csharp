using System;

namespace CSharpLab.Abstract
{
  class Program
  {
    static void Main(string[] args)
    {
      var circle = new Circle(1);
      Console.WriteLine($"Area of circle with radius {circle.Radius}: {circle.Area():0.0000}");

      var rectangle = new Rectangle(4, 9.8);
      Console.WriteLine($"Area of rectangle with dimensions {rectangle.Height}*{rectangle.Width}: {rectangle.Area():0.0000}");
    }
  }
}

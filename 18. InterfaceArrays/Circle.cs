using System;

namespace CSharpLab.InterfaceArrays
{
  public class Circle : IShape
  {
    public double Radius { get; set; }
    public string Name => nameof(Circle);

    public double Area() => Math.PI * Radius * Radius;

    public void Input()
    {
      Console.Write("Enter radius: ");
      var radius = double.Parse(Console.ReadLine().Trim());

      this.Radius = radius;
    }

    public double NumberOfPoints() => double.PositiveInfinity;
  }
}
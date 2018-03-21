using System;

namespace CSharpLab.InterfaceArrays
{
  public class Rectangle : IShape
  {
    public double Length { get; set; }
    public double Breadth { get; set; }

    public string Name => nameof(Rectangle);

    public double Area() => this.Length * this.Breadth;

    public void Input()
    {
      Console.Write("Enter length: ");
      var length = double.Parse(Console.ReadLine().Trim());
      this.Length = length;

      Console.Write("Enter breadth: ");
      var breadth = double.Parse(Console.ReadLine().Trim());
      this.Breadth = breadth;
    }

    public double NumberOfPoints() => 4;
  }
}
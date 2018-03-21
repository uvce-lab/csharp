using System;

namespace CSharpLab.InterfaceArrays
{
  public class Cuboid : Rectangle, IShape
  {
    public double Height { get; set; }

    public new string Name => nameof(Cuboid);

    public new double Area() => base.Area() * this.Height;

    public new void Input()
    {
      base.Input();

      Console.Write("Enter height: ");
      var height = double.Parse(Console.ReadLine().Trim());
      this.Height = height;
    }

    public new double NumberOfPoints() => 8;
  }
}
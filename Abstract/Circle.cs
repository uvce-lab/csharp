using System;

namespace CSharpLab.Abstract
{
  public class Circle : Shape
  {
    public Circle(double radius)
    {
      this.radius = radius;
    }

    private double radius;
    public double Radius => radius;
    public override double Area()
    {
      var area = Math.PI * radius * radius;
      return area;
    }
  }
}
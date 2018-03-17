using System;
using System.Collections.Generic;

namespace CSharpLab.QuadraticEquation
{
  public class Equation
  {
    private double a, b, c;

    public Equation(double a, double b, double c)
    {
      this.a = a; this.b = b; this.c = c;
    }

    public string Roots()
    {
      var discriminant = b * b - 4 * a * c;

      if (discriminant >= 0)
      {
        var discriminantRoot = Math.Sqrt(discriminant);
        var roots = new double[] {
          (-b + discriminantRoot) / (2 * a),
          (-b - discriminantRoot) / (2 * a),
        };

        return $"{roots[0]}, {roots[1]}";
      }
      else
      {
        var discriminantRoot = Math.Sqrt(-discriminant);
        var roots = new string[] {
          $"{-b/(2 * a)} + {discriminantRoot / (2 * a)}i",
          $"{-b/(2 * a)} - {discriminantRoot / (2 * a)}i"
        };

        return $"{roots[0]}, {roots[1]}";
      }
    }
  }
}
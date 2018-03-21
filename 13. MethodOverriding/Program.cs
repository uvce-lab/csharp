using System;

namespace CSharpLab.MethodOverriding
{
  class Program
  {
    static void Main(string[] args)
    {
      Action<dynamic> _printer = (dynamic value) => { Console.WriteLine(value.Draw()); };

      Shape shape = new Shape();
      _printer(shape);

      Triangle triangle = new Triangle();
      _printer(triangle);

      shape = new Triangle();
      _printer(shape);
    }
  }
}
using System;

namespace CSharpLab.Properties
{
  class Program
  {
    static void Main(string[] args)
    {
      var myLaptop = new Computer()
      {
        Name = "Dell Inspiron 3537",
        ClockSpeed = "1600MHz"
      };

      Console.WriteLine(myLaptop.ToString());
    }
  }
}

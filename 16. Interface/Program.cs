using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Interface
{
  class Program
  {
    static void Main(string[] args)
    {
      var students = new List<Student>
      {
        new Student("Harrison Wells", "14GAEC9004"),
        new Student("Aaron S","14GAEC9001"),
        new Student("Diana P","14GAEC9003"),
        new Student("Barry Allen","14GAEC9002"),
      };

      students.Sort();

      Console.WriteLine("Sorted students: ");
      students.ForEach(Console.WriteLine);
    }
  }
}

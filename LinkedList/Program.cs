using System;
using System.Collections.Generic;

namespace CSharpLab.LinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      var list = new LinkedList<string>();

      do
      {
        Console.Write(@"
MENU:
1. Add item to the beginning
2. Display the list
3. Display number of nodes in the list
4. Exit
Enter your choice: ");

        var choice = Console.ReadLine().Trim();

        switch (choice)
        {
          case "1":
            Console.Write("Enter item to insert at the beginning: ");
            var item = Console.ReadLine().Trim();
            list.AddFirst(item);
            break;

          case "2":
            Console.WriteLine($"The list contains:\n[{String.Join(" --> ", list)}]");
            break;
          
          case "3":
            Console.WriteLine($"The list contains {list.Count} node(s).");
            break;

          case "4":
            return;
          
          default:
            Console.WriteLine("You entered an invalid choice: ");
            break;
        }
      } while (true);
    }
  }
}

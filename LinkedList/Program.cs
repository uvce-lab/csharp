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
2. Remove item from the beginning
3. Display the list
4. Display number of nodes in the list
5. Exit
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
            if (list.Count == 0)
              Console.WriteLine("Underflow Exception: Cannot remove node from an empty list.");
            else
            {
              var firstNode = list.First;
              list.RemoveFirst();
              Console.WriteLine($"Removed {firstNode.Value} from the list.");
            }
            break;

          case "3":
            Console.WriteLine($"The list contains:\n[{String.Join(" --> ", list)}]");
            break;

          case "4":
            Console.WriteLine($"The list contains {list.Count} node(s).");
            break;

          case "5":
            return;

          default:
            Console.WriteLine("You entered an invalid choice: ");
            break;
        }
      } while (true);
    }
  }
}

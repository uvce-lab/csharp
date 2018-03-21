using System;
using System.Collections.Generic;
using System.Linq;

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
3. Add item to the end
4. Remove item from the end
5. Remove all matching nodes
6. Display the list
7. Display number of nodes in the list
8. Exit
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
            Console.Write("Enter the item to insert at the end: ");
            var lastItem = Console.ReadLine().Trim();
            list.AddLast(lastItem);
            break;

          case "4":
            if (list.Count == 0)
              Console.WriteLine("Underflow Exception: Cannot remove node from an empty list.");
            else
            {
              var lastNode = list.Last;
              list.RemoveLast();
              Console.WriteLine($"Removed {lastNode.Value} from the list.");
            }
            break;

          case "5":
            Console.Write("Enter query to remove all occurences: ");
            var match = Console.ReadLine().Trim();

            var temp = list.First;
            var nodesToRemove = new List<LinkedListNode<string>>();
            while (temp != null)
            {
              if (temp.Value == match)
                nodesToRemove.Add(temp);
              temp = temp.Next;
            }

            nodesToRemove.ForEach(p => list.Remove(p));

            Console.WriteLine($"Removed {nodesToRemove.Count} nodes.");
            break;

          case "6":
            Console.WriteLine($"The list contains:\n[{String.Join(" --> ", list)}]");
            break;

          case "7":
            Console.WriteLine($"The list contains {list.Count} node(s).");
            break;

          case "8":
            return;

          default:
            Console.WriteLine("You entered an invalid choice: ");
            break;
        }
      } while (true);
    }
  }
}

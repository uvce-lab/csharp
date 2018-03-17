using System;

namespace CSharpLab.Stack
{
  class Program
  {
    static void Main()
    {
      var stack = new Stack<string>();

      do
      {
        Console.Write("STACK MENU\n1. Push Item\n2. Pop Item\n3. Display Stack\n4. Display Stack length\n5. Exit\nEnter your choice: ");

        var choice = Console.ReadLine().Trim();

        switch (choice)
        {
          case "1":
            Console.Write("Enter item to push: ");
            var item = Console.ReadLine().Trim();
            stack.Push(item);
            break;

          case "2":
            try
            {
              var poppedItem = stack.Pop();
              Console.WriteLine($"Item popped: {poppedItem}");
            }
            catch (Exception e)
            {
              Console.WriteLine(e.Message);
            }
            break;

          case "3":
            Console.WriteLine($"Stack contents: {Environment.NewLine}{stack}");
            break;

          case "4":
            Console.WriteLine($"Stack contains {stack.Count} items.");
            break;

          case "5":
            return;

          default:
            Console.WriteLine("You entered an invalid choice");
            break;
        }
      } while (true);
    }
  }
}

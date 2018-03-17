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
        Console.Write("STACK MENU\n1. Push Item\n2. Pop Item\nEnter your choice: ");

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

          default:
            Console.WriteLine("You entered an invalid choice");
            break;
        }
      } while (true);
    }
  }
}

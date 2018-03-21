using System;

namespace CSharpLab.Calculator
{
  public class Runner
  {
    public static void Main()
    {
      do
      {
        try
        {
          Console.WriteLine("Enter values in expression: \'a op b\'");
          Console.WriteLine("\'a\' and \'b\' are operands - integers");
          Console.WriteLine("\'op\' is the operation - (+, -, *, or / )");
          var expression = Console.ReadLine().Trim();
          Console.WriteLine(Calculator.Calculate(expression));

          Console.WriteLine("Wish to enter more expressions? (Yn)");
          var choice = Console.ReadLine().Trim().ToUpper();
          switch (choice)
          {
            case "N": return;
            case "":
            case "Y":
            default: continue;
          }
        }
        catch (Exception e)
        {
          Console.WriteLine($"{e.Message}");
          break;
        }
      } while (true);
    }
  }
}
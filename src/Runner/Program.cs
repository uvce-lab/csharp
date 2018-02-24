using System;
using System.Linq;

using CSharpLab.Palindrome;

namespace CSharpLab
{
  public class Runner
  {
    public static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("NOTE: Pass arguments: <ProgramNumber> <Arguments>");
        return;
      }

      if (int.TryParse(args[0], out int programNumber))
      {
        switch (programNumber)
        {
          case 1:
            {
              Palindrome.Runner.EntryPoint(args.ToList().Skip(1));
              break;
            }
          case 2:
            {
              CommandLineArgs.Runner.EntryPoint(args.ToList().Skip(1));
              break;
            }
          default:
            {
              Console.WriteLine("Aborting. The program number is either not implemented yet or out of range.");
              break;
            }
        }

        return;
      }
      
      Console.WriteLine("Aborting. Enter program number (0 - 18).");
    }
  }
}
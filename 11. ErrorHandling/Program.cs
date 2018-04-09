using System;
using System.IO;
using System.Text;

namespace CSharpLab.ErrorHandling
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length < 1)
        Console.WriteLine("NOTE: Enter file path as the first command-line argument.");

      var filePath = args[0];
      var fileContents = new StringBuilder();
      StreamReader fileStream = null;

      try
      {
        //Open the file
        fileStream = new StreamReader(filePath);

        //Read until end of stream is reached
        while (!fileStream.EndOfStream)
          fileContents.Append($"{fileStream.ReadLine()}{Environment.NewLine}");

        //Display the file contents
        Console.WriteLine(fileContents.ToString());
      }
      catch (Exception e)
      {
        //Display error message, if any.
        Console.WriteLine(e.Message);
      }
      finally
      {
        //Close the file
        fileStream?.Close();
      }
    }
  }
}

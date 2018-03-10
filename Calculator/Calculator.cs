using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpLab.Calculator
{
  public static class Calculator
  {
    public static double Calculate(string expression)
    {
      try
      {
        var (firstOperand, secondOperand, operation) = ParseExpression(expression);
        switch (operation)
        {
          case "+":
            return firstOperand + secondOperand;
          case "-":
            return firstOperand - secondOperand;
          case "*":
            return firstOperand * secondOperand;
          case "/":
            return firstOperand / secondOperand;
          default:
            throw new Exception("Invalid operation.");
        }
      }
      catch (Exception) { throw; }
    }

    public static (double firstOperand, double secondOperand, string operation)
      ParseExpression(string expression)
    {
      var parts = Regex.Match(expression, @"^\s*(\-?[0-9]+)\s*([\+\-\*\/])\s*(\-?[0-9]+)\s*$");

      if (!parts.Success)
        throw new Exception("You entered an invalid expression.");

      var operandConversionFailedMessage = "{0} operand is invalid.";

      var firstOperand = convertOperand(parts.Groups[1].Value,
      String.Format(operandConversionFailedMessage, "first"));

      var secondOperand = convertOperand(parts.Groups[3].Value,
      String.Format(operandConversionFailedMessage, "second"));

      return (firstOperand, secondOperand, parts.Groups[2].Value);
    }

    private static double convertOperand(string operand, string message)
    {
      if (double.TryParse(operand, out double result))
        return result;
      throw new Exception(message);
    }
  }
}
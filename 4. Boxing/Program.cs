using System;
using System.Collections.Generic;

namespace CSharpLab.Boxing
{
  public class Runner
  {
    public static void Main()
    {
      double valueType = 1.414;

      // Implicit boxing to an object representation
      object boxed = valueType;

      Console.WriteLine($"The value type value: {valueType}");
      Console.WriteLine($"The boxed value: {boxed}");

      // Changing valueType doesn't change the boxed value as it was copied
      valueType = 3.1415926;
      Console.WriteLine($"When valueType is changed: {valueType}");
      Console.WriteLine($"The boxed value: {boxed}");

      // Casting valueType to double is valid
      double castValue = (double)valueType;
      Console.WriteLine($"Cast valueType to double: {castValue}");

      // Casting object to double is valid
      double castObject = (double)boxed;
      Console.WriteLine($"Unbox object to double: {castObject}");

      // Casting valueType to int is valid
      double castValueToInt = (int)valueType;
      Console.WriteLine($"Cast valueType to int: {castValueToInt}");

      try
      {
        // Trying to unbox object to int value results in an error
        // as conversion between two differenct object types (System.Double
        // and System.Int32) is not valid
        int castObjectToInt = (int)boxed;
        
        Console.WriteLine($"Unbox object to int", castObjectToInt);
      }
      catch (Exception e)
      {
        Console.WriteLine($"Exception: {e.Message}");
      }
    }
  }
}

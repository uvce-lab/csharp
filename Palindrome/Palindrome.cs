using System.Linq;

namespace Palindrome
{
  class Palindrome
  {
    public static bool Check(long number)
    {
      var stringRep = number.ToString();
      var reversed = string.Join("", stringRep.Reverse()).ToString();
      return stringRep == reversed;
    }
  }
}
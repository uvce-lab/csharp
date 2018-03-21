using System.Text;

namespace CSharpLab.ReverseString
{
  static class StringExtensions
  {
    public static string Reverse(this string value)
    {
      var reverseStringBuilder = new StringBuilder();
      for (var i = value.Length - 1; i >= 0; --i)
        reverseStringBuilder.Append(value[i]);
      return reverseStringBuilder.ToString();
    }
  }
}
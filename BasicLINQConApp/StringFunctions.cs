
using System.Text;

namespace BasicLINQConApp
{
  // Step I class has to be static
  public static class StringFunctions
  {

    // Step II mark the first arg of the method with keyword 'this'
    public static string Mahesh(this string value)
    {
      char[] chars = value.ToCharArray();
      StringBuilder sBuilder = new StringBuilder();
      for (int i = chars.Length-1; i >=0; i--) 
      {
        sBuilder.Append(chars[i]);
      }
      return sBuilder.ToString();
    }
  }
}

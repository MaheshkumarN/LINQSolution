using static System.Console;

namespace BasicLINQConApp
{
  public static class Printer
  {
    public static void PrintHeader(string headerMessage = null, string pattern = "-", int noOfTimesPattern = 100)
    {
      int headerMessageLength = 0;
      if (!string.IsNullOrEmpty(headerMessage))
      {
        headerMessageLength = headerMessage.Length;
      }

      for (int i = 1; i < (noOfTimesPattern - headerMessageLength); i++)
      {
        Write($"{pattern}");
        if (((noOfTimesPattern - headerMessageLength) / 2) == i)
        {
          Write($"{headerMessage}");
        }
      }
      WriteLine($"");
    }

    public static void PrintFooter(string pattern = "-", int noOfTimesPattern = 100)
    {
      for (int i = 1; i < noOfTimesPattern; i++)
      {
        Write($"{pattern}");
      }
      WriteLine($"");
    }

    public static void Print(string message, string headerMessage = null, string pattern = "-", int noOfTimesPattern = 100)
    {
      PrintHeader(headerMessage, pattern, noOfTimesPattern);
      WriteLine($"{message}");
      PrintFooter(pattern, noOfTimesPattern);
    }


    public static void Print<T>(T message, string headerMessage = null, string pattern = "-", int noOfTimesPattern = 100)
    {
      PrintHeader(headerMessage, pattern, noOfTimesPattern);
      WriteLine($"{message.GetType()}");
      PrintFooter(pattern, noOfTimesPattern);
    }
  }
}

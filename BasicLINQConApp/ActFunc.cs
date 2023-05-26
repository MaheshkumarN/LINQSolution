using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLINQConApp
{
  public static class ActFunc
  {
    public static void CalcAction(int value1, int value2, string mOperator)
    {
      switch (mOperator)
      {
        case "+":
          Printer.Print($"{(value1 + value2)}", $"Sum of {value1}, {value2}");
          break;
        case "*":
          Printer.Print($"{(value1 * value2)}", $"Multiplication of {value1}, {value2}");
          break;
        case "/":
          Printer.Print($"{(value1 / value2)}", $"Division of {value1}, {value2}");
          break;
        case "-":
          Printer.Print($"{(value1 - value2)}", $"Subtraction of {value1}, {value2}");
          break;
      }
    }

    public static int Calc(int value1, string mOperator)
    {
      int result = 0;
      switch (mOperator)
      {
        case "+":
          result = (value1 + 2);
          break;
        case "*":
          result = (value1 * 2);
          break;
        case "/":
          result = (value1 / 2);
          break;
        case "-":
          result = (value1 - 2);
          break;
        default:
          result = value1;
          break;
      }
      return result;
    }

    public static int Calc(int value1, int value2, string mOperator)
    {
      int result = 0;
      switch (mOperator)
      {
        case "+":
          result = (value1 + value2);
          break;
        case "*":
          result = (value1 * value2);
          break;
        case "/":
          result = (value1 / value2);
          break;
        case "-":
          result = (value1 - value2);
          break;
        default:
          break;
      }
      return result;
    }
  }
}

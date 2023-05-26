using BasicLINQConApp.Models.Entities;

namespace BasicLINQConApp
{
  // Step I
  public delegate bool FilterFN<S>(S value);
  public static class Utilities
  {
    public static List<Employee> Filter(this List<Employee> sourceList)
    {
      List<Employee> temp = new List<Employee>();
      foreach (var item in sourceList)
      {
        if (item.Salary > 3000)
        {
          temp.Add(item);
        }
      }
      return temp;
    }
    public static List<T> Filter<T>(this List<T> sourceList, FilterFN<T> del)
    {
      List<T> temp = new List<T>();
      foreach (var item in sourceList)
      {
        if (del(item))
        {
          temp.Add(item);
        }
      }
      return temp;
    }
  }
}

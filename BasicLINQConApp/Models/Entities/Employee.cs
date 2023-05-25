namespace BasicLINQConApp.Models.Entities
{
  public class Employee
  {
    int _age;
    string _empName;

    public int Age
    { 
      get { return _age; }
      set 
      {
        if (value < 1) throw new Exception("Age cannot be less than 1");
        _age = value; 
      }
    }

    public string EmpName
    {
      get { return _empName; }
      set { _empName = value; }
    }

  }
}

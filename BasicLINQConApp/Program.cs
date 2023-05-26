using static System.Console;
using BasicLINQConApp.Models.Entities;
using BasicLINQConApp;

#region Default
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#endregion


#region old Initialization and Properties
//Employee emp = new Employee();
//emp.Age = 10;
//emp.EmpName = "Phantom";
//WriteLine($"{emp}"); 
#endregion


#region AutoImplemented Properties, Object and Collection Initialization
//Employee emp = new Employee { EmpNo = 10, EmpName = "Tintin", Age = 10, Salary = 2000.21m };

//WriteLine($"{emp}");

//List<Employee> empList = new List<Employee>();
//empList.Add(new Employee { });

//List<Employee> empList = new List<Employee>
//{

//};

//Dictionary<int, Employee> dempList = new Dictionary<int, Employee>
//{
//  [1] = new Employee { },
//};

#endregion

#region Emp List
List<Employee> empList = new List<Employee>()
			{
			new Employee() { EmpNo = 17, EmpName = "Jerry", Salary = 2102, Age = 16 },
			new Employee() { EmpNo = 27, EmpName = "Tom", Salary = 3100, Age = 19 },
			new Employee() { EmpNo = 21, EmpName = "Snowy", Salary = 5000, Age = 41 },
			new Employee() { EmpNo = 12, EmpName = "Tintin", Salary = 1900, Age = 17 },
			new Employee() { EmpNo = 19, EmpName = "Donald", Salary = 8000, Age = 25 },
			new Employee() { EmpNo = 20, EmpName = "Mickey", Salary = 2700, Age = 18 },
			new Employee() { EmpNo = 41, EmpName = "Mini", Salary = 7500, Age = 28 },
			new Employee() { EmpNo = 13, EmpName = "Spiderman", Salary = 9000, Age = 34 },
			new Employee() { EmpNo = 52, EmpName = "Superman", Salary = 5000, Age = 29 },
			new Employee() { EmpNo = 10, EmpName = "Batman", Salary = 4900, Age = 33 },
			new Employee() { EmpNo = 22, EmpName = "Jughead", Salary = 3000, Age = 28 },
			new Employee() { EmpNo = 11, EmpName = "Archie", Salary = 6000, Age = 26 },
			new Employee() { EmpNo = 33, EmpName = "Betty", Salary = 1500, Age = 22 },
			new Employee() { EmpNo = 56, EmpName = "Veronica", Salary = 3700, Age = 21 },
			new Employee() { EmpNo = 63, EmpName = "Reggie", Salary = 4000, Age = 30 },
			new Employee() { EmpNo = 87, EmpName = "Twoface", Salary = 8000, Age = 36 },
			new Employee() { EmpNo = 91, EmpName = "Phantom", Salary = 12000, Age = 29 },
			new Employee() { EmpNo = 81, EmpName = "Joker", Salary = 13000, Age = 39 },
			new Employee() { EmpNo = 96, EmpName = "Haddock", Salary = 7000, Age = 30 },
			new Employee() { EmpNo = 29, EmpName = "Thompson", Salary = 4000, Age = 32 }
			};

#endregion


#region Extension Method
//string name = "Donald";

//WriteLine($"{name}");
//WriteLine($"{name.ToLower()}");
//WriteLine($"{name.ToUpper()}");
//WriteLine($"{name}");
//WriteLine($"StringFunctions.Mahesh = {StringFunctions.Mahesh(name)}");
////WriteLine($"{name.Mahesh()}");
//name.Print("Name");
//empList.Print("Employee List"); 
#endregion

#region Criteria given by the client where sal is greater than 3000
//empList.Filter().Print("Emp With Sal > 3000"); 
#endregion

#region Criteria not given beforehand by the client
//empList.Filter(GetBySal).Print("Get By Sal > 4000");
//empList.Filter(GetByName).Print("Get By Name StartsWith 'J'");
#endregion

#region With Anonymous Methods for the delegate, also know as InLine Code
//empList.Filter(delegate(Employee e) { return e.Salary > 4000; }).Print("Get By Sal > 4000");
//empList.Filter(delegate(Employee e) { return e.Age > 32; }).Print("Emp's with Age > 32");
//empList.Filter(delegate(Employee e) { return e.EmpName.StartsWith("J"); }).Print("Get By Name StartsWith 'J'");
#endregion

//Step I
static bool GetBySal(Employee emp)
{
	if (emp.Salary > 4000)
		return true;
	return false;
}

static bool GetByName(Employee emp)
{
	if (emp.EmpName.StartsWith("J"))
		return true;
	return false;
}


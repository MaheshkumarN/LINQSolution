using static System.Console;
using BasicLINQConApp.Models.Entities;
using BasicLINQConApp;
using System.Security.Cryptography;
using System.Linq.Expressions;

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

#region With Lambda delegate replace with '=>'
//empList.Filter(delegate(Employee e) { return e.Salary > 4000; }).Print("Get By Sal > 4000");
//empList.Filter((Employee e) => { return e.Salary > 4000; }).Print("Get By Sal > 4000");

//empList.Filter(delegate(Employee e) { return e.Age > 32; }).Print("Emp's with Age > 32");
//empList.Filter((Employee e) => { return e.Age > 32; }).Print("Emp's with Age > 32");

//empList.Filter(delegate(Employee e) { return e.EmpName.StartsWith("J"); }).Print("Get By Name StartsWith 'J'");
//empList.Filter((Employee e) => { return e.EmpName.StartsWith("J"); }).Print("Get By Name StartsWith 'J'");


//IEnumerable<Employee> newEmpList  = empList.Filter((Employee e) => { return e.EmpName.StartsWith("J"); });
//newEmpList.Print("Get By Name StartsWith 'J'");


//empList.Where(e => e.Age > 32).Print("All Emp's with Age > 32");
//empList.Where(e => e.Age > 32).AsQueryable().Print("All Emp's with Age > 32");

//IEnumerable<Employee> newEmpList = empList.Where(e => e.EmpName.StartsWith("J"));
//Printer.Print(newEmpList, "All Emp's With EmpName StartingWith 'J'");

// Error as LINQ will return IEnumerable
//IList<Employee> newEmpList = empList.Where(e => e.EmpName.StartsWith("J"));

//IList<Employee> newEmpList = empList.Where(e => e.EmpName.StartsWith("J")).ToList();
//Printer.Print(newEmpList, "All Emp's With EmpName StartingWith 'J'");
#endregion

#region With Query Expression

//IEnumerable<Employee> newEmpList  = empList.Filter((Employee e) => { return e.EmpName.StartsWith("J"); });
//IEnumerable<Employee> newEmpList  = from e in empList
//																		where e.EmpName.StartsWith("J")
//																		select new Employee { EmpNo = e.EmpNo, EmpName = e.EmpName, Salary = e.Salary, Age = e.Age };
//Printer.Print(newEmpList, "All Emp's with Name Starting in 'J'");

//empList.Where(e => e.Age > 32).Print("All Emp's with Age > 32");
//IList<Employee> newEmpListList = (from e in empList
//																 where e.Age > 20 && e.Salary > 3000
//																 select new Employee { EmpNo = e.EmpNo, EmpName = e.EmpName, Salary = e.Salary, Age = e.Age }).ToList();
//newEmpListList.Print("With Query Expression, call to ToList()");

#endregion

#region var keyword
//var name = 10;
//name = "str";

//var newEmpList = (from e in empList
//									where e.EmpName.StartsWith("T")
//									select new Employee { EmpNo = e.EmpNo, EmpName = e.EmpName, Salary = e.Salary, Age = e.Age }).ToList();

//newEmpList.Print("Emp with Name startingwith 'T'");

//var newEmpList1 = (from e in empList
//									where e.EmpName.StartsWith("T")
//									select new Employee { EmpNo = e.EmpNo, EmpName = e.EmpName, Salary = e.Salary, Age = e.Age }).ToArray();
//Printer.Print(newEmpList1.GetType().Name, "Type of newEmpList1");
//newEmpList1.Print("Emp with Name startingwith 'T'");
#endregion

#region Anonymous Type
//var result = (from e in empList
//							where e.Salary > 4000
//							select new { Name = e.EmpName, Age = e.Age}).ToList();

//result.Print("Anonymous Type");

//Printer.Print(result.ToString(), "Anonymous Type");
#endregion

#region Action Fire and forget
//Action<int, int, string> actCalc = new Action<int, int, string>(ActFunc.CalcAction);

//actCalc(10, 2, "/");
//actCalc(10, 2, "+");
//actCalc(10, 2, "*");
//actCalc(10, 2, "-");
#endregion

#region Func
//Func<int, string, int> CalcFunc = new Func<int, string, int>(ActFunc.Calc);
//Printer.Print($"{CalcFunc(10, "+")}", $"CalcFun(10, '+')");

//Func<Employee, bool> FuncByAge = e => e.Age > 28;
//empList.Where(FuncByAge).Print("Age > 28");

//int ctr = 1;
//foreach (var item in empList)
//{
//	if (FuncByAge(item))
//	{
//		WriteLine($"{ctr++} -- {item}");
//	}
//}
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

#region Expression

//Step I
//body
//parameter/s
//nodetype (lambda)
//returnType

//Expression<Func<Employee, bool>> isSeniorExpression = e => e.Age > 35;
//Expression<Func<Employee, bool>> isMidLevelExpression = e => e.Age >= 20 && e.Age <= 30;
//Step II Compile the Expression
//Func<Employee,bool> isSenior = isSeniorExpression.Compile();
//Func<Employee, bool> isMidLevel = isMidLevelExpression.Compile();

// Step III
//bool isArchieSr = isSenior(new Employee { EmpNo = 101, EmpName = "Archie", Salary = 2000, Age=3});

//bool isJugheadMidLevel = isSenior(new Employee { EmpNo = 102, EmpName = "Jughead", Salary = 2000, Age = 21 });

//Printer.Print($"{isArchieSr}", "Is Archie Senior");
//empList.Where(isSenior).Print("Only Senior Emp's");

//Printer.Print($"{isJugheadMidLevel}", "Is Jughead Mid Level");
//empList.Where(isMidLevel).Print("Only Mid Emp's");
#endregion

#region Breakup of Expression
//Printer.Print($"{isMidLevelExpression}", "Expression");
//Printer.Print($"{isMidLevelExpression.NodeType}", "Expression Type");
//Printer.PrintHeader("Parameter List");
//var parameterList = isMidLevelExpression.Parameters;
//foreach (var item in parameterList)
//{
//	WriteLine($"Name: {item.Name}, Type: {item.Type}");
//}
//Printer.PrintFooter();
////var expressionBody = isMidLevelExpression.Body;
//var expressionBody = isMidLevelExpression.Body as BinaryExpression;
//Printer.Print($"{expressionBody}", "Body");
//Printer.Print($"{expressionBody.Left}", "Body Expression Left");
//Printer.Print($"{expressionBody.NodeType}", "Body Expression Node Type");
//Printer.Print($"{expressionBody.Right}", "Body Expression Right");
//Printer.Print($"{isMidLevelExpression.ReturnType}", "MidLevelExpression Return Type");

#endregion

#region Expression Tree
//Step I ParameterExpression
ParameterExpression employeeParameter = Expression.Parameter(typeof(Employee), "e");

//Step II MemberExpression
MemberExpression ageMemberExpression = Expression.Property(employeeParameter, "Age");

//Step III ConstantExpression
ConstantExpression ageConstant = Expression.Constant(30, typeof(int));

//Step IV BinaryExpression
BinaryExpression body = Expression.GreaterThanOrEqual(ageMemberExpression, ageConstant);

//Step V ExpressionTree
var expressionTree = Expression.Lambda<Func<Employee, bool>>(body, employeeParameter);

Printer.Print($"{expressionTree}", "ExpressionTree");
Printer.Print($"{expressionTree.Body}", "ExpressionTree Body");
Printer.Print($"{expressionTree.Parameters.Count}", "ExpressionTree Parameters Count");
Printer.Print($"{expressionTree.Parameters[0]}", "ExpressionTree Parameters[0]");

Func<Employee, bool> isSenior = expressionTree.Compile();
empList.Where(isSenior).Print("List of Senior Employees");
#endregion
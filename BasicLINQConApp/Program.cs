using static System.Console;
using BasicLINQConApp.Models.Entities;

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


Employee emp = new Employee { EmpNo = 10, EmpName = "Tintin", Age = 10, Salary = 2000.21m };

WriteLine($"{emp}");
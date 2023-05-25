using static System.Console;
using BasicLINQConApp.Models.Entities;

#region Default
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#endregion


Employee emp = new Employee();
emp.Age = 10;
emp.EmpName = "Phantom";
WriteLine($"{emp}");
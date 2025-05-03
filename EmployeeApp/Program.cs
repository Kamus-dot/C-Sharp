using EmployeeApp;
using System;
using System.Runtime.ConstrainedExecution;

Employee emp = new Employee("Marvinkjjjhjhjhjjhjh", 45, 123, 1000, "111-11-1111",
EmployeePayTypeEnum.Hourly);
Console.WriteLine(emp.Pay);
emp.GiveBonus(100);
Console.WriteLine(emp.Pay);

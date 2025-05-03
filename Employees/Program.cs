using Employees;
using System;
using System.Data;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("***** The Employee Class Hierarchy *****\n");
SalesPerson fred = new SalesPerson
{
    Age = 31,
    Name = "Fred",
    SalesNumber = 50
};
fred.DisplayStats();
fred.GiveBonus(200);

Console.WriteLine();

PtSalesPerson ptsale = new PtSalesPerson("Vovchick", 30, 73737, 30000, "SSD3343", 12);
ptsale.DisplayStats();

Console.WriteLine("***** The Employee Class Hierarchy ***** \n");
Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
double cost = chucky.GetBenefitCost();
chucky.GiveBonus(200);
chucky.DisplayStats();
Console.WriteLine();
Console.WriteLine($"Benefit Cost: {cost}");
Console.WriteLine();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-993-23", 31);
fran.GiveBonus(200);
fran.DisplayStats();
Console.WriteLine();

object frank = new Manager();
Hexagon hex;
try
{
    hex = (Hexagon)frank;
}
catch (InvalidCastException ex)
{
    Console.WriteLine(ex.Message);
}

Employee[] employees = { new Manager(), new SalesPerson() };
foreach (Employee s in employees)
{
    s.DisplayStats();
}

CastingExamples();

object[] things = new object[4];
things[0] = new Hexagon();
things[1] = false;
things[2] = new Manager();
things[3] = "Last thing";
foreach (object item in things)
{
    Hexagon h = item as Hexagon;
    if (h == null)
    {
        Console.WriteLine("Item is not a hexagon"); // item - не Hexagon
    }
    else
    {
        h.Draw();
    }
}


static void CastingExamples()
{
    // Manager "является" System.Object, поэтому в переменной
    // типа object можно сохранять ссылку на Manager,
    object frank = new Manager("Frank Zappa", 9, 3000, 40000,
    "111-11-1111", 5);
    // Manager тоже "является" Employee.
    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000,
    "101-11-1321", 1);
    // PtSalesPerson "является" Salesperson.
    SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000,
    "111-12-1119", 90);
    Manager.GivePromotion(moonUnit);
    Console.WriteLine();
}




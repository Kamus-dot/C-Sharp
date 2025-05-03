using System;
using System.ComponentModel;
EmpTypeEnum emp = EmpTypeEnum.Plodder;
EmpTypeEnum SalesmanManager = EmpTypeEnum.Manager | EmpTypeEnum.Salesman;
Console.WriteLine($"Salesman? - {(SalesmanManager | EmpTypeEnum.Manager) == SalesmanManager}");
AskForRise(emp);
Console.WriteLine(Enum.GetUnderlyingType(emp.GetType()));
Console.WriteLine(emp.GetType());
Console.WriteLine(emp.ToString());
Array empData = Enum.GetValues(emp.GetType());
for (int i = 0; i < empData.Length; i++)
{
    Console.WriteLine($"Name {empData.GetValue(i)}, Value {empData.GetValue(i):D}");
}

static string AskForRise(EmpTypeEnum e)
{
    return e switch
    {
        EmpTypeEnum.Manager => "Sorry, we can't afford it",
        EmpTypeEnum.Salesman => "Sorry, we need hands able to manage with goods",
        EmpTypeEnum.Boss => "You're highest person at this place, it's ceiling",
        EmpTypeEnum.Plodder => "Nah, sorry",
        _ => "Who are You?"
    };
}

[Flags]
enum EmpTypeEnum : byte
{
    Manager = 1,
    Plodder = 2,
    Salesman = 3,
    Boss = 4
}
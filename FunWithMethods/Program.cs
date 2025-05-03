using System;
using System.Collections;
using System.Security.Cryptography;
// using FunWithMethodOverloading;
// using static FunWithMethodOverloading.AddOperations;
// int x = 10_000;
DayOfWeek day = DayOfWeek.Monday;
ConsoleColor clr = ConsoleColor.DarkYellow;

Console.WriteLine(ParamCheck([12.4, 546.75, 545.67, 86.4]));
Exp(out double crack);
Console.WriteLine(crack);
Console.WriteLine("Fun with Methods");
DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
textColor: ConsoleColor.DarkRed,
backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
message: "Testing...",
textColor: ConsoleColor.DarkBlue);
EmpTypeEnum emp = EmpTypeEnum.Plodder;
Console.WriteLine(AskForRise(emp));
Console.WriteLine($"{Enum.GetUnderlyingType(emp.GetType())}");
Console.WriteLine($"emp is {emp}");
Console.WriteLine($"emp is {emp.ToString()} = {(byte)emp}");
EvaluateEnum(emp);
EvaluateEnum(day);
EvaluateEnum(clr);

Console.ReadLine();


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

static void EvaluateEnum(System.Enum e)
{
    Console.WriteLine("=> Information about {0}", e.GetType());
    // Вывести лежащий в основе тип хранилища.
    Console.WriteLine("Underlying storage type: {0}",
    Enum.GetUnderlyingType(e.GetType()));
    // Получить все пары "имя-значение" для входного параметра.
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members.", enumData.Length);
    // Вывести строковое имя и ассоциированное значение,
    // используя флаг формата D (см. главу 3).
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}",
        enumData.GetValue(i));
    }
    Console.WriteLine();
}

static double ParamCheck(params double[] values)
{
    double sum = new();
    Console.WriteLine($"You sent me {values.Length} values");
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return values.Length == 0 ? sum : sum / values.Length;
}

static void Exp(out double sav, string str = "Hello", params double[] values)
{
    sav = 0;
}

static void DisplayFancyMessage(ConsoleColor textColor,
ConsoleColor backgroundColor, string message)
{
    //Сохранить старые цвета для их восстановления после вывода сообщения
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Установить новые цвета и вывести сообщение.
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Восстановить предыдущие цвета.
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}
enum EmpTypeEnum : byte
{
    Manager = 1,
    Plodder = 2,
    Salesman = 3,
    Boss = 4
}




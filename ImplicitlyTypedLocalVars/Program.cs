using System.Linq;
using System.Net.WebSockets;
using System.Xml.XPath;
LinqQueryOverlnts();
IfElsePatternMatching();
IfElsePatternMatchingUpdatedInCSharp9();
Example();
ExecutePatternMatchingSwitch();
ExecutePatternMatchingSwitchWithWhen();
Console.WriteLine(RockPaperScissors("rock","paper"));
static void LinqQueryOverlnts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    // Запрос LINQ!
    var subset = from i in numbers where i < 10 select i;
    Console.Write("Values in subset: ");
    foreach (var i in subset)
    {
        Console.Write("{0} ", i);
    }
}
static void IfElsePatternMatching()
{
    Console.WriteLine("===If Else Pattern Matching ===/n");
    object testlteml = 123;
    object testltem2 = "Hello";
    if (testlteml is string myStringValuel)
    {
        Console.WriteLine($"{myStringValuel} is a string");
        // testlteml имеет тип string
    }
    if (testlteml is int myValuel)
    {
        Console.WriteLine($"{myValuel} is an int"); // testlteml имеет тип int
    }
    if (testltem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string");
        // testltem2 имеет тип string
    }
    if (testltem2 is int myValue2)
    {
        Console.WriteLine($"{myValue2} is an int"); // testltem2 имеет тип int
    }
    Console.WriteLine();
}
static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("===== C# 9 If Else Pattern Matching");
    object testlteml = 123;
    Type t = typeof(string);
    char c = 'f';
    object Test = 1222;
    // Образцы типов
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
        // t является Type
    }
    // Относительные, конъюнктивные и дизъюнктивные образцы
    if (c is >= 'a' and <= 'z' or >= 'А' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
        // с является символом
    };
    // Образцы в круглых скобках
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
        // c является символом или разделителем
    }
    // Инвертированные образцы
    if (testlteml is not string)
    {
        Console.WriteLine($"{testlteml} is not a string");
        // с не является строкой
    }
    if (testlteml is not null)
    {
        Console.WriteLine($"{testlteml} is not null");
        // с не является null
    }
    if (Test is not string)
    {
        Console.WriteLine("Hi");
    }
    Console.WriteLine();
}
static void Example()
{
    string wer = "Hello";
    var res = wer is string ? "Pridurok" : "Atitude";
    Console.WriteLine(res.GetType());
    Console.WriteLine(wer.Length > res.Length ? wer : res);
}
static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string? userChoice = Console.ReadLine();
    object choice;
    // Стандартный оператор switch, в котором применяется
    // сопоставление с образцом с константами
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5;
            break;
        default:
            choice = 5;
            break;
    }
    Console.WriteLine(choice);
    Console.WriteLine(choice.GetType());
    // Новый оператор switch, в котором применяется
    // сопоставление с образцом с типами
    switch (choice)
    {
        case int:
            Console.WriteLine("Your choice is an integer.");
            // Выбрано целое число
            break;
        case string:
            Console.WriteLine("Your choice is a string.");
            // Выбрана строка
            break;
        case double:
            Console.WriteLine("Your choice is a decimal.");
            // Выбрано десятичное число
            break;
        default:
            Console.WriteLine("Your choice is something else");
            // Выбрано что-то другое
            break;
    }
    Console.WriteLine();
}
static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    object? langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice?.ToString(),
    out int c) ? c : langChoice;
    Console.WriteLine(c);
    Console.WriteLine(choice?.GetType());
    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB",
    StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            // VB: ООП, многопоточность и многое другое!
            break;
        case int i when i == 1:
        case string s when s.Equals("C#",
    StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language.");
            // Хороший выбор. C# - замечательный язык.
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            // Хорошо, удачи с этим!
            break;
    }
    Console.WriteLine();
}
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

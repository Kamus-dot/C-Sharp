using System;
using System.Runtime.InteropServices;
Console.WriteLine("***** Fun With Action and Func *****");
// Использовать делегат Action<> для указания на метод DisplayMessage().
Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);

Func<int, int, int> funcTarget = Add;
int result = funcTarget.Invoke(40, 40);
Func<int, int, string> funcTarget2 = SumToString;
string str = funcTarget2.Invoke(90, 200);
Console.WriteLine(str);

static void DisplayMessage(
    string msg, ConsoleColor txtColor, int printCount)
{
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    Console.ForegroundColor = previous;
}
static int Add(int x, int y)
{
    return x + y;
}
static string SumToString(int x, int y)
{
    return (x + y).ToString();
}
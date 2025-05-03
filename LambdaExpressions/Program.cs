using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using LambdaExpressions;

Console.WriteLine("***** Fun With Labdas *****\n");
DelegateSyntax();
SimpleMath m = new SimpleMath();
// Это приведёт к выполнению лямбда-выражению.
m.SetMathHandler((msg, result) =>
{ Console.WriteLine("Message: {0}, Result: {1}", msg, result); });
// Можно записать так:
// m.SetMathHandler((string msg, int result) =>
// {...});
SimpleMath.VerySimpleDelegate d = () => { return "Hello There!"; };
Console.WriteLine(d);
m.Add(10, 10);

var outerVariable = 0;
Func<int, int, bool> DoWork = static (x, y) =>
{
    // outerVariable++; - Вызавет ошибку
    return true;
};
// Func<int, int, bool> DoWork1 = (x, y) =>
// {
//     outerVariable ++;
//     return true;
// };
DoWork(3, 4);
Console.WriteLine("OuterVariable now: {0}", outerVariable);
// DoWork1(_,_);
// Console.WriteLine("OuterVariable now: {0}", outerVariable);

static void DelegateSyntax()
{
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 8, 4, 9, 44 });
    Predicate<int> callback = IsEvenNumber;
    List<int> evenNumbers = list.FindAll(callback);
    // Возможен еще следующий вариант:
    List<int> evenNumbers2 = list.FindAll(delegate (int i)
    { return i % 2 == 0; });
    // И самый удобный вариант через лямбда-выражение:
    List<int> evenNumbers3 = list.FindAll(i => (i % 2) == 0);
    // Или так:
    List<int> evenNumbers4 = list.FindAll((i) =>
    {
        Console.WriteLine("value of i is currently: {0}", i);
        bool isEven = ((i % 2) == 0);
        return isEven;
    });
    Console.WriteLine("Here are your numbers: ");
    foreach (int evenNumber in evenNumbers)
    {
        Console.WriteLine("{0}\t", evenNumber);
    }
    Console.WriteLine("-----------");
    foreach (int evenNumber in evenNumbers2)
    {
        Console.WriteLine("{0}\t", evenNumber);
    }
    Console.WriteLine("-----------");
    foreach (int evenNumber in evenNumbers3)
    {
        Console.WriteLine("{0}\t", evenNumber);
    }
    Console.WriteLine("-----------");
    foreach (int evenNumber in evenNumbers4)
    {
        Console.WriteLine("{0}\t", evenNumber);
    }
}
static bool IsEvenNumber(int i)
{
    return (i % 2) == 0;
}




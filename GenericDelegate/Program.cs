using System;
Console.WriteLine("***** Generic Delegates *****");
MyGenericDelegate<string> strTarget =
new MyGenericDelegate<string>(StringTarget);
strTarget("Some string data");
// Использовать синтаксис группового преобразования методов.
MyGenericDelegate<int> intTarget = IntTarget;
intTarget(9);

static void StringTarget(string arg)
{
    Console.WriteLine("arg in uppercase is {0}", arg.ToUpper());
}
static void IntTarget(int arg)
{
    Console.WriteLine("++arg is: {0}", ++arg);
}
// Этот обобщенный делегат может вызывать любой метод, который
// возвращает void и принимает единственный параметр тира T.
public delegate void MyGenericDelegate<T>(T arg);
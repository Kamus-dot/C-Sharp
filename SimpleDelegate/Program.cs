using System;
using System.Dynamic;
using SimpleDelegate;

Console.WriteLine("***** Simple Delegate Example *****\n");
// Создать объект делегата BinaryOp, который
// "указывает" на SimpleMath.Add().
SimpleMath m = new SimpleMath();
BinaryOp b = new BinaryOp(m.Add);
DisplayDelegateInfo(b);
// Вызвать метод Add() косвенно с использованием объекта делегата.
Console.WriteLine("10 + 10 is {0}", b(10, 10));
Console.WriteLine("10 + 10 is {0}", b.Invoke(10, 10));
// Console.WriteLine($"10 + 10 is {SimpleMath.Add(10, 10)}");
// Дополнительные определения типов должны находиться
// в конце операторов верхнего уровня.
// Этот делегат может указывать на любой метод, 
// принимающий два целых числа и возвращающий целое число.
static void DisplayDelegateInfo (Delegate delObj)
{
    foreach(Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine($"Method Name: {d.Method}"); // Имя метода
        Console.WriteLine($"Type Name: {d.Target}"); // Имя типа
    }
}
public delegate int BinaryOp(int x, int y);

using System;
using CustomGenericMethods;

int a = 10, b = 90;
Console.WriteLine("Before swap: {0}, {1}", a, b);
SwapFunctions.Swap<int>(ref a, ref b);
Console.WriteLine("After swap: {0}, {1}", a, b);
Console.WriteLine();

// Поменять местами два строковых значения.
string si = "Hello", s2 = "There";
Console.WriteLine("Before swap: {0} {1}!", si, s2);
SwapFunctions.Swap<string>(ref si, ref s2);
Console.WriteLine("After swap: {0} {1}!", si, s2);

// Компилятор выведет тип System.Boolean.
bool bl = true, b2 = false;
Console.WriteLine("Before swap: {0}, {1}", bl, b2);
SwapFunctions.Swap(ref bl, ref b2);
Console.WriteLine("After swap: {0}, {1}", bl, b2);

// Если метод не принимает параметров,
// т о должен быть указан параметр типа.
DisplayBaseClass<int>();
DisplayBaseClass<string>();
// Ошибка на этапе компиляции! Нет параметров?
// Должен быть предоставлен заполнитель!
// DisplayBaseClass();

static void DisplayBaseClass<T>()
{
    // BaseType - метод, используемый в рефлексии;
    // он будет описан в главе 17.
    Console.WriteLine("Base class of {0} is: {1}.",
    typeof(T), typeof(T).BaseType);
}

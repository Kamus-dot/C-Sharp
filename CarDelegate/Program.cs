using System;
using CarDelegate;
Console.WriteLine("** Delegate as event enablers **\n");
// Создать объект Car.
Car c1 = new Car("SlugBag", 100, 10);
// Сообщить объекту Car, какой метод вызывать,
// когда он пожелает отправить сообщение.
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
c1.RegisterWithCarEngine(handler2);
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
c1.UnRegisterWithCarEngine(handler2);
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

Console.WriteLine("***** Method Group Conversion *****\n");
Car c2 = new Car();
// Зарегистрировать простое имя метода
// Так можно задавать только когда существует только
// один экземпляр делегата с такими входными и выходными параметрами. 
c2.RegisterWithCarEngine(OnCarEngineEvent);
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c2.Accelerate(20);
}
c2.UnRegisterWithCarEngine(OnCarEngineEvent);
Console.WriteLine("--------------");
for (int i = 0; i < 6; i++)
{
    c2.Accelerate(20);
}

static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("\n*** Message From Car Object ***");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("******************\n");
}
static void OnCarEngineEvent2(string msg)
{
    Console.WriteLine("=> {0}", msg.ToUpper());
}
// Короче, тут суть в том, чтобы соединить метод из Program.cs и интегрировать его в класс (это происходит
// при вызове метода Accelerate) для вызова метода. (Как бы получается метод в методе, 
// но находящихся в разных cs файлах).
// 
// Групповой вызов методов происходит в порядке их объявления
using System;
using CarEvents;
Console.WriteLine("***** Fun With Envents *****\n");
Car c1 = new Car("SlugBug", 100, 10);
c1._Exploded += _CarIsAlmostDoomed;
c1.AboutToBlow += CarAboutToBlow;
Car.CarEngineHandler d = CarExploded;
c1.Exploded += d;
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
c1.Exploded -= d;
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

static void _CarIsAlmostDoomed(object? sender, CarEventArgs e)
{
    Console.WriteLine(e.msg);
}
static void CarAboutToBlow(object sender, string msg)
{
    Console.WriteLine($"{sender} says: {msg}");
}
static void CarIsAlmostDoomed(object sender, string msg)
{
    Console.WriteLine($"=> Critical Message from {sender}: {msg}");
}
static void CarExploded(object sender, string msg)
{
    Console.WriteLine($"--- {sender} says: {msg}");
}
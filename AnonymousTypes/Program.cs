using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("*****Fun With Anonymous Types*****");
var Mycar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
ReflectOverAnonymousType(Mycar);
BuildAnonymousType("Honda", "Grey", 70);
EqualityTest();

static void BuildAnonymousType(string make, string color, int currSp)
{
    var car = new { Make = make, Color = color, Speed = currSp };
    Console.WriteLine($"Make: {car.Make}, Color: {car.Color}, Speed = {car.Speed}");
}

static void ReflectOverAnonymousType(object obj)
{
    Console.WriteLine("obj is an instance of {0}", obj.GetType().Name);
    Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
    Console.WriteLine("obj.ToString() == {0}", obj.ToString());
#pragma warning disable CS8974 // Converting method group to non-delegate type
    Console.WriteLine("obj.GetHashCode == {0}", obj.GetHashCode);
#pragma warning restore CS8974 // Converting method group to non-delegate type
}

static void EqualityTest()
{
    var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
    var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
    if (firstCar.Equals(secondCar))
    { Console.WriteLine("Same anonymous object!"); }
    else
    { Console.WriteLine("Not the same anonymous object!"); }
    if (firstCar == secondCar)
    { Console.WriteLine("Same anonymous object!"); }
    else
    { Console.WriteLine("Not the same anonymous object!"); }
    if (firstCar.GetType().Name == secondCar.GetType().Name)
    { Console.WriteLine("Same anonymouse object!"); }
    else
    { Console.WriteLine("Not the same anonymous object!"); }
    Console.WriteLine();
    ReflectOverAnonymousType(firstCar);
    ReflectOverAnonymousType(secondCar);
}
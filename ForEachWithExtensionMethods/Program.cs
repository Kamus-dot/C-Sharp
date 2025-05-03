using System;
using ForEachExtensionMethods;

Console.WriteLine("*****Support for Extention Method GetEnumerator*****\n");
Garage carLot = new Garage();
foreach (Car c in carLot)
{
    Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
}

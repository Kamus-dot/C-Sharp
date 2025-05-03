using CustomEnumeratorWithYield;
using System;
using System.Collections;

Console.WriteLine("******** Fun With Yield Keyword *******");
Garage carLot = new Garage();
try{
IEnumerator carEnumerator = carLot.GetEnumerator();
}
catch(Exception c)
{
    Console.WriteLine(c.Message);
    
}
Console.WriteLine(carLot.GetType());

Garage garages = new Garage();

try
{
    foreach (Car c in garages)
    {
        Console.WriteLine(c.PetName);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.Data);
}



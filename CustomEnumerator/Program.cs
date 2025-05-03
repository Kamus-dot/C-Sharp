using CustomEnumerator;
using System.Collections;

Console.WriteLine("******** Fun With IEnumerable / IEnumerator *******\n");

Garage carLot = new Garage();

foreach (Car c in carLot)
{
    Console.WriteLine(c.PetName);
}

IEnumerator carEnumerator = carLot.GetEnumerator();
carEnumerator.MoveNext();
Car myCar = (Car)carEnumerator.Current;
Console.WriteLine($"{myCar.PetName} is going {myCar.CurrentSpeed} MPH");
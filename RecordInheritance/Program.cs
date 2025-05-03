using System;
using RecordInheritance;
Console.WriteLine("Record type inheritance!");
Car c = new Car("Honda","Pilot","Blue");
MiniVan m = new MiniVan("Honda", "Pilot", "Blue",10);
Console.WriteLine($"Checking MiniVan is-а Car:{m is Car}");
// Проверка, является ли MiniVan типом Car

PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
PositionalMiviVan pm = new PositionalMiviVan ("Honda", "Pilot", "Blue", 10);
Console.WriteLine($"Checking PositionalMiniVan is-а PositionalCar:{pm is PositionalCar}");



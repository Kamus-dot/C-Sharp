using BasicInferitance;

Console.WriteLine("******* Basic Inheritance *******");
Car mycar = new Car(80) { Speed = 50 };
Console.WriteLine($"My car is going {mycar.Speed} MPH");
Console.WriteLine($"My car's limit is {mycar.MaxSpeed} MPH\n");

MiniVan myVan = new MiniVan { Speed = 50 };
Console.WriteLine($"My van is going {mycar.Speed} MPH");
Console.WriteLine($"My van's limit is {mycar.MaxSpeed} MPH");
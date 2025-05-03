using System;
using System.Reflection;
using FunWithRecords;

Console.WriteLine("******* Fun With Records *******");
Car myCar = new Car
{
    Mike = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My Car: ");
DisplayCarStats(myCar);
Console.WriteLine();

Car anotherMyCar = new Car("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
DisplayCarStats(anotherMyCar);
Console.WriteLine();

Console.WriteLine("******* RECORDS *******");
// Использовать инициализацию объекта.
CarRecord myCarRecord = new CarRecord
{
    Mike = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
Console.WriteLine();
// Использовать специальный конструктор.
CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot",
"Blue");
Console.WriteLine("Another variable for my car: ");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();
// Попытка изменения свойства приводит к ошибке на этапе компиляции.
// myCarRecord.Color = "Red";
Console.ReadLine();
Console.WriteLine($"Cars are the same? {myCar.Equals(anotherMyCar)}");
Console.WriteLine($"Cars are the same reference? {ReferenceEquals(myCar, anotherMyCar)}");
Console.WriteLine($"CarRecords are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
// Эквивалентны ли экземпляры CarRecord?
Console.WriteLine($"MCarRecords are the same reference? {ReferenceEquals(myCarRecord, anotherMyCarRecord)}");
// Указывают ли экземпляры CarRecord на тот же самый объект?
Console.WriteLine($"CarRecords are the same? {myCarRecord == anotherMyCarRecord}");
Console.WriteLine($"CarRecords are not the same? {myCarRecord != anotherMyCarRecord}");

CarRecord ourOtherCar = myCarRecord with { Model = "Odyssey" };
Console.WriteLine("My copied car:");
Console.WriteLine(ourOtherCar.ToString());
Console.WriteLine("Car Record copy using with expression results");
// Результаты копирования CarRecord
// с использованием выражения with
Console.WriteLine($"CarRecords are the same? {ourOtherCar.Equals(myCarRecord)}");
Console.WriteLine($"CarRecords are the same? {ReferenceEquals(ourOtherCar, myCarRecord)}");

static void DisplayCarStats(Car c)
{
    Console.WriteLine("Car Make: {0}", c.Mike);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}

static void DisplayCarRecordStats(CarRecord c)
{
    Console.WriteLine("Car Make: {0}", c.Mike);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}
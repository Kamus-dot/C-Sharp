using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using LinqOverCollections;

Console.WriteLine("*****LINQ over Generic Collections *****\n");
// Создать список List<int> объектов Car.
List<Car> myCars = new List<Car>
{
new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
};
GetFastCars(myCars);
Console.WriteLine();
GetFastBMW(myCars);
LINQOverArrayList();
OfTypeAsFilter();


static void GetFastCars(List<Car> myCars)
{
    // Найти List<> все объекты Car, у которых значение Speed больше 55.
    var fastCars = from c in myCars where c.Speed > 55 select c;
    foreach (var car in fastCars)
    {
        Console.WriteLine("{0} is going too fast!", car.PetName);
    }
}
static void GetFastBMW(List<Car> cars)
{
    var FastBMW = from c in cars where c.Speed > 90 && c.Make == "BMW" select c;
    foreach (var car in FastBMW)
    {
        Console.WriteLine("{0} is going too fast!", car.PetName);
    }
}
static void LINQOverArrayList()
{
    // Необобщенная коллекция объектов Car.
    ArrayList myCars = new ArrayList() {
    new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
    new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
    new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
    new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
    new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
    };
    // Трансформировать ArrayList в тип, совместимый c IEnumerable<T>.
    var myCarsEnum = myCars.OfType<Car>();
    // Создать выражение запроса, нацеленное на совместимый с IEnumerable<T> тип
    var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
    foreach (var car in fastCars)
    {
        Console.WriteLine("{0} is going too fast!", car.PetName);
    }
}
static void OfTypeAsFilter()
{
    ArrayList myStuff = new ArrayList();
    myStuff.AddRange(new object[] {10, 400, 8, false, new Car(), "string data"});
    var myInts = myStuff.OfType<int>();
    // Выводит 10, 400 и 8.
    Console.WriteLine(myInts.GetType().Name);
    foreach(int i in myInts)
    {
        Console.WriteLine(i);
    }
}

using System;
using System.Linq;
DisplayDiff();
DisplayIntersection();
DisplayUnion();
DisplayConcat();
DisplayConcatNoDups();
AggregateOps();

static void DisplayDiff()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
    var carDiff =
    (from c in myCars select c).Except(from c2 in yourCars select c2);
    Console.WriteLine("Here is what you don't have, but I do:");
    foreach (string s in carDiff)
    {
        Console.WriteLine(s);
    }
}
static void DisplayIntersection()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Aztec", "Saab" };
    var carIntersect =
    (from c in myCars select c).Intersect(from c2 in yourCars select c2);
    Console.WriteLine("\nHere is what we have common:");
    foreach (string str in carIntersect)
    {
        Console.WriteLine(str);
    }
}
static void DisplayUnion()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Aztec", "Saab" };
    var carIntersect =
    (from c in myCars select c).Union(from c2 in yourCars select c2);
    Console.WriteLine("\nThere are all of our cars:");
    foreach (string str in carIntersect)
    {
        Console.WriteLine(str);
    }
}
static void DisplayConcat()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Aztec", "Saab" };
    var carIntersect =
    (from c in myCars select c).Concat(from c2 in yourCars select c2);
    Console.WriteLine();
    foreach (string str in carIntersect)
    {
        Console.WriteLine(str);
    }
}
static void DisplayConcatNoDups()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Aztec", "Saab" };
    var carIntersect =
    (from c in myCars select c).Concat(from c2 in yourCars select c2);
    Console.WriteLine();
    foreach (string str in carIntersect.Distinct())
    {
        Console.WriteLine(str);
    }
}
static void AggregateOps()
{
    double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
    // Разнообразные примеры агрегации
    // Выводит максимальную температуру:
    Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());
    // Выводит минимальную температуру
    Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());
    Console.WriteLine("Average temp: {0}", (from t in winterTemps select t).Average());
    Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());
}


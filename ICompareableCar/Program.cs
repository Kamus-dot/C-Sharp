using CompareableCar;

Console.WriteLine("******** Fum With Object String ********");
Car[] myAutos = new Car[5];
myAutos[0] = new Car("1", 80, 1);
myAutos[1] = new Car("2", 40, 234);
myAutos[2] = new Car("3", 40, 34);
myAutos[3] = new Car("4", 40, 4);
myAutos[4] = new Car("5", 40, 5);

// Отобразить текущее содержимое массива.
Console.WriteLine("Here is the unordered set of cars:");
foreach (Car c in myAutos)
{
    Console.WriteLine("{0} {1}", c.CarID, c.PetName);
}
// Теперь отсортировать массив с применением IComparable!
Array.Sort(myAutos);
Console.WriteLine();
// Отобразить отсортированное содержимое массива.
Console.WriteLine("Неге is the ordered set of cars:");
foreach (Car c in myAutos)
{
    Console.WriteLine($"{c.CarID} {c.PetName}");
}

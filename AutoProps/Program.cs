using System.Drawing;
using AutoProps;
using ObjectInitializers;

Car car = new Car();
car.Color = "Red";
Console.WriteLine(car.Color);
car.DisplayStats();
Console.WriteLine();

Garage g = new Garage();
Console.WriteLine($"Number of Cats: {g.NumberofCats}");
Console.WriteLine($"{g.MyAuto.PetName}");

Console.WriteLine("******* Fun with Object Init Syntax *******");
ObjectInitializers.Point firstpoint = new ObjectInitializers.Point();
firstpoint.X = 10;
firstpoint.Y = 10;
firstpoint.DisplayStats();

ObjectInitializers.Point anotherpoint = new ObjectInitializers.Point(20, 30);
anotherpoint.DisplayStats();

ObjectInitializers.Point finalpoint = new ObjectInitializers.Point(PointColorEnum.LightBlue) { X = 30, Y = 90 };
finalpoint.DisplayStats();

PointReadOnlyAfterCreation firstReadOnlyPoint = new PointReadOnlyAfterCreation(20, 20);
firstReadOnlyPoint.DisplayStats();

PointReadOnlyAfterCreation secondReadOnlyPoint = new PointReadOnlyAfterCreation { X = 40, Y = 80 };
secondReadOnlyPoint.DisplayStats();

ObjectInitializers.Rectangle myReact = new ObjectInitializers.Rectangle
{
    TopLeft = new ObjectInitializers.Point {X = 10, Y = 10},
    BottomRight = new ObjectInitializers.Point {X = 200, Y = 200}
};




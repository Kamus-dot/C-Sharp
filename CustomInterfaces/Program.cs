using System;
using CustomInterfaces;

Console.WriteLine("******* A First Look at Interfaces *******\n");

Hexagon hex = new Hexagon();
Console.WriteLine($"Points: {hex.Points}");

Circle c = new Circle("Lisa");
IPointy? itfPt = null;
try
{
    itfPt = (IPointy)c;
    Console.WriteLine(itfPt.Points);
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}

Hexagon hex2 = new Hexagon("Peter");
IPointy itfPt2 = hex2 as IPointy;
if (itfPt2 != null)
{
    Console.WriteLine($"Points: {itfPt2.Points}");
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}

if (hex2 is IPointy itfPt3)
{
    Console.WriteLine("Points: {0}", itfPt3.Points);
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}

var sq = new Square("Boxy")
{
    NumberOfSides = 4,
    SideLength = 4
};
sq.Draw();
Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter {((IRegularPointy)sq).Perimeter}");

Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
IRegularPointy.ExampleProperty = "Updated";
Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");

Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("Jojo") };

for (int i = 0; i < myShapes.Length; i++)
{
    if (myShapes[i] is IDraw3D itf3d)
    {
        DrawIn3D(itf3d);
    }
}
CloneableExample();

IPointy? firstfoundpointy = FindFirstPointyShape(myShapes);
Console.WriteLine($"Points of the first found class mantaining IPointy {firstfoundpointy?.Points}\n");

IPointy[] myPointObjects = [new Hexagon(), new Knife(), new Triangle(), new Fork(), new Pichfork()];
foreach (IPointy i in myPointObjects)
{
    Console.WriteLine($"Object {i.GetType().Name} has {i.Points} Points");
}
Console.WriteLine();
static void DrawIn3D(IDraw3D itf3d)
{
    Console.WriteLine("-> Drawing IDraw3D compatible type");
    itf3d.Draw3D();
}

static void CloneableExample()
{
    // Все эти классы поддерживают интерфейс ICloneable.
    string myStr = "Hello";
    OperatingSystem unixOS =
    new OperatingSystem(PlatformID.Unix, new Version());
    // Следовательно, все они могут быть переданы методу,
    // принимающему параметр типа ICloneable.
    CloneMe(myStr);
    CloneMe(unixOS);
    static void CloneMe(System.ICloneable c)
    {
        // Клонировать то, что получено, и вывести имя.
        object theClone = c.Clone();
        Console.WriteLine("Your clone is a: {0}",
        theClone.GetType().Name);
    }
}

static IPointy? FindFirstPointyShape(Shape[] shapes)
{
    foreach (Shape s in shapes)
    {
        if (s is IPointy ip)
        {
            return ip;
        }
    }
    return null;
}
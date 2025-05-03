using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("******A First Look At Structures******");
// 
// 
Point point = new Point(50, 77, "");
point.Display();
point.Decrement();
point.Display();
point.Increment();
point.Display();
Console.WriteLine("\n");
// 
// 
ReadOnlyPoint rdonly = new ReadOnlyPoint(100, 15);
rdonly.Display();
Console.WriteLine("\n");
// 
// 
var s = new DisposableRefStruct(50, 60);
s.Display();
s.Dispose();
Console.WriteLine("\n");
// 
// 
struct Point
{
    // Поля структуры,
    public int X;
    public int Y;
    public readonly string Name;
    public Point(int Posx, int Posy, string name)
    {
        X = Posx; Y = Posy;
        Name = name;
    }
    // Добавить 1 к позиции (X, Y).
    public void Increment()
    {
        X++; Y++;
    }
    // Вычесть 1 из позиции (X, Y).
    public void Decrement()
    {
        X--; Y--;
    }
    // Отобразить текущую позицию,
    public readonly void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

readonly struct ReadOnlyPoint
{
    public int X { get; }
    public int Y { get; }
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    public ReadOnlyPoint(int PosX, int PosY)
    {
        X = PosX; Y = PosY;
    }
}

ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X={X}, Y = {Y}");
    }
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos; Y = yPos;
        Console.WriteLine("Created!");
    }
    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }
}
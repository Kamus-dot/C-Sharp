using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
namespace AutoProps
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point() { }
        public void DisplayStats()
        {
            Console.WriteLine($"Coords: [{X}, {Y}]");
        }

    }
}
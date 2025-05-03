using System;
using System.Diagnostics.Contracts;
namespace ObjectInitializers
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColorEnum Color { get; set; }
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColorEnum.Gold;
        }
        public Point() : this(PointColorEnum.Bloodred) { }
        public Point(PointColorEnum ptColor)
        {
            Color = ptColor;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
            Console.WriteLine($"Point is {Color}");
        }
    }
    class PointReadOnlyAfterCreation
    {
        public int X { get; init; }
        public int Y { get; init; }
        public void DisplayStats()
        {
            Console.WriteLine($"InitOnlySetter: [{X}, {Y}]");
        }
        public PointReadOnlyAfterCreation(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public PointReadOnlyAfterCreation() { }
    }
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();
        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }
        public void DisplayStats()
        {
            Console.WriteLine($"[TopLeft: {TopLeft.X}, {TopLeft.Y}, {TopLeft.Color}]");
            Console.WriteLine($"[BottomRight: {BottomRight.X}, {BottomRight.Y}, {BottomRight.Color}]");
        }
    }
}
using System;
using System.Numerics;
namespace OverloadedOps
{
    // Простой будничный класс С#,
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        // Перегруженный оператор "+"
        public static Point operator +(Point p1, Point p2)
        => new Point(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator +(Point p1, int change)
        => new Point(p1.X + change, p1.Y + change);
        public static Point operator +(int change, Point p1)
        => new Point(p1.X + change, p1.Y + change);
        // Перегруженный оператор "-"
        public static Point operator -(Point p1, Point p2)
        => new Point(p1.X - p2.X, p1.Y - p2.Y);
        public static Point operator -(Point p1, int change)
        => new Point(p1.X - change, p1.Y - change);
        public static Point operator -(int change, Point p1)
        => new Point(change - p1.X, change - p1.X);
        // Перегруженный оператор "++"
        public static Point operator ++(Point p1)
        => new Point(p1.X + 1, p1.Y + 1);
        public override string ToString()
        => $"[{this.X}, {this.Y}]";
        //для перегруженной операции ++ выражение pt++ дает значение неизмененного объекта, 
        //в то время как результатом ++pt будет новое значение, устанавливаемое перед использованием в выражении).
        public override bool Equals(object o)
        => o.ToString() == this.ToString();
        public override int GetHashCode()
        => this.ToString().GetHashCode();
        public static bool operator ==(Point p1, Point p2)
        => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2)
        => !p1.Equals(p2);
        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y) { return 1; }
            if (this.X < other.X && this.Y < other.Y) { return -1; }
            return 0;
        }
        public static bool operator <(Point pt1, Point pt2)
        => pt1.CompareTo(pt2) < 0;
        public static bool operator >(Point pt1, Point pt2)
        => pt1.CompareTo(pt2) > 0;
        public static bool operator >=(Point pt1, Point pt2)
        => pt1.CompareTo(pt2) >= 0;
        public static bool operator <=(Point pt1, Point pt2)
        => pt1.CompareTo(pt2) <= 0;
    }
}

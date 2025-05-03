using System.Net.Http.Headers;
using CloneablePoint;

Point p1 = new Point(50, 50, "A");
Point p2 = p1;
p2.X = 20;
Console.WriteLine(p1.X);
Console.WriteLine(p2.X);
Console.WriteLine(p1.desc.PointID);
Console.WriteLine(p2.desc.PointID);
Point p3 = (Point)p2.Clone();

Console.WriteLine(p1.X);
Console.WriteLine(p2.X);
Console.WriteLine(p3.X);
Console.WriteLine(p1.desc.PointID);
Console.WriteLine(p2.desc.PointID);
Console.WriteLine(p3.desc.PointID);

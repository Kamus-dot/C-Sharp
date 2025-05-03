using System;
using CustomConversions;

Console.WriteLine("***** Fun With Conversions *****\n");
Rectangle r = new Rectangle(15, 4);
Console.WriteLine(r.ToString());
r.Draw();
Console.WriteLine();
// Преобразовать r в Square на основе высоты Rectangle.
Square s = (Square) r;
Console.WriteLine(s.ToString());
s.Draw();
// Преобразование (явное) ectangle в Square
Rectangle rect = new Rectangle(10, 5);
Square sq = (Square) rect;
Square.DrawSquare(sq);
// Преобразование (явное) int в Square
Square sq2 = (Square) 90;
Console.WriteLine(sq2);
// Преобразование наоборот Square в int 
int side = (int) sq2;
Console.WriteLine(side);
// Преобразование (неявное) Square в Rectangle
Square s3 = new Square(7);
Rectangle rect2 = s3;
Console.WriteLine(rect2.ToString());
// Синтаксис явного приведения тоже работает
Square s4 = new Square(5);
Rectangle rect3 = (Rectangle) s4;
Console.WriteLine(rect3.ToString()); 
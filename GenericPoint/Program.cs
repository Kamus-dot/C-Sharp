using System;
using GenericPoint;

Console.WriteLine("***** Fun With Generic Structures *****\n");

Point<int> p = new Point<int>(10, 10);
Console.WriteLine(p);
p.ResetPoint();
Console.WriteLine(p);
Console.WriteLine();

Point<double> p2 = new Point<double>(5.4, 3.3);
Console.WriteLine(p2);
p2.ResetPoint();
Console.WriteLine(p2);
Console.WriteLine();

Point<string> p3 = new Point<string>("i", "3i");
Console.WriteLine(p3);
p3.ResetPoint();
Console.WriteLine(p3);
Console.WriteLine();

Point<string> p4 = default;
Console.WriteLine("p4.ToString()={0}", p4.ToString());
Console.WriteLine();

Point<int> p5 = default;
Console.WriteLine("p5.ToString()={0}", p5.ToString());
PatternMatching(p4);
PatternMatching(p5);


static void PatternMatching<T>(Point<T> p)
{
    switch (p)
    {
        case Point<string> pString:
            Console.WriteLine("Point is based on strings");
            // Структура Point основана на типе string
            return;
        case Point<int> pint:
            Console.WriteLine("Point is based on ints");
            // Структура Point основана на типе int
            return;
    }
}
// Этот метод меняет местами любые структуры, но не классы,
static void Swap<T>(ref T a, ref T Ь) where T : struct
{
}



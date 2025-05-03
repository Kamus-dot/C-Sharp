using System;
using System.Globalization;
using System.Runtime.Versioning;
Exp3();
// static void PowerOf2()
// {
//     int c1 = new(), i = new();
//     double d1 = new();
//     int l = new();
//     IFormatProvider format = new NumberFormatInfo { NumberDecimalSeparator = "." };
//     do
//     {
//         Console.WriteLine("Enter your number, higher than 0:");
//         string C = Console.ReadLine();
//         if (int.TryParse(C, out int c) && c >= 0)
//         {
//             c1 = c;
//             l = 0;
//         }
//         else if (double.TryParse(C, format, out double d) && d >= 0)
//         {
//             d1 = d;
//             l = 1;
//         }
//         else
//         {
//             Console.WriteLine("Please, enter your number, higher than 0:");
//             l = -1;
//         }
//     }
//     while (l == -1);
//     if (l == 0)
//     {
//         while (c1 >= Math.Pow(i, 2))
//         {
//             i++;
//             Console.Write($"{Math.Pow(i, 2)}\t");
//         }
//     }
//     if (l == 1)
//     {
//         while (d1 >= Math.Pow(i, 2))
//         {
//             Console.Write($"{Math.Pow(i, 2)}\t");
//             i++;
//         }
//     }
// }
// static void A41()
// {
//     int d, c;
//     Console.WriteLine("Enter two-digit number:");
//     do
//     {
//         if (!int.TryParse(Console.ReadLine(), out d) || d < 10 || d >= 100)
//         {
//             Console.WriteLine("Please, enter two-digit number:");
//         }
//     }
//     while (d < 10 || d >= 100);
//     Console.WriteLine("OK, now enter one-digit number:");
//     do
//     {
//         if (!int.TryParse(Console.ReadLine(), out c) || c >= 10 || c < 0)
//         {
//             Console.WriteLine("Please, enter one-digit number:");
//             c = -1;
//         }
//     }
//     while (c < 0 || c >= 10);
//     Console.WriteLine($"Hey, You got d = {d}");
//     Console.WriteLine($"Hey, You got c = {c}");
//     Console.WriteLine($"{(int)(d + c) / 10} - Количество десятков");
//     Console.WriteLine($"{d + c - ((int)(d + c) / 10) * 10} - Количество единиц");
// }
static void Exp3()
{
    Random rnd = new Random();
    int h = rnd.Next(13);
    int m = rnd.Next(60);
    double delay = new();
    Console.WriteLine($"Amount of hours: {h}");
    Console.WriteLine($"Amount of minutes: {m}");
    //Ряды представляют собой убывающую геометрическую прогрессию
    if (h * 5 > m)
    {
        // for (int i = 0; i <= 5; i++)
        // {
        //     delay = (double)(h * 5 - m) / Math.Pow(12, i) + delay;
        //     sec = delay;
        // }
        delay = (double)(h * 5 - m) / 5.5;
        Console.WriteLine($"Should pass {(int)delay} minutes, {(delay - (int)delay) * 60:f2} seconds, before they cross");
    }
    else
    {
        // for (int i = 0; i <= 5; i++)
        // {
        //     delay = (double)(60 - m + h * 5) / Math.Pow(12, i) + delay;
        //     sec = delay;
        // }
        delay = (double)(60 - m + h * 5) / 5.5;
        Console.WriteLine($"Should pass {(int)delay} minutes, {(delay - (int)delay) * 60:f2} seconds, before they cross");
        
    }

}


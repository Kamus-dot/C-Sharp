using System;
using System.ComponentModel;
using System.Text;
Console.WriteLine("Enter your string: ");
#pragma warning disable CS8602 
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string Str = Console.ReadLine();

// ?
if (Str.Contains(','))
{
    for (int i = 0; i < Str.IndexOf(','); i++)
    {
        Console.Write($"'{Str[i]}' ");
    }
}
else
{
    Console.WriteLine("Sorry, fy");
}
// 

// 
for (int i = 0; i < Str.Length / 2; i++)
{
    if (Str[i] != Str[Str.Length - i - 1])
    {
        Console.WriteLine("Не перевёртыш");
        break;
    }
    if (i == Str.Length / 2 - 1)
    {
        Console.WriteLine("Перевёртыш, congratulations!");
    }
}
// 
char[] a = Str.ToCharArray();
char[] b = new char[a.Length];
Array.Copy(a, b, a.Length);
Array.Reverse(b);
for (int i = 0; i < a.Length; i++)
{
    if (a[i] == b[i])
    {
        Console.Write(true + " ");
    }
    else
    {
        Console.Write(false + " ");
    }
}

#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 

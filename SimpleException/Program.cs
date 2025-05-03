using System;
using SimpleException;
using System.Collections;
using System.Linq.Expressions;

Console.WriteLine("*******Simple Exception Example*******");
Console.WriteLine("=> Creating a car and stepping on it");

Car mycar = new Car("Zippy", 20);

mycar.CrankTunes(true);
try
{
    for (int i = 0; i < 10; i++)
    {
        mycar.Accelerate(10);
    }
}
catch (Exception e)
{
    Console.WriteLine("\n*******Error*******\n");
    Console.WriteLine($"Member name: {e.TargetSite}");
    Console.WriteLine($"Class defining member: {e.TargetSite?.DeclaringType}");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"Source: {e.Source}");
    Console.WriteLine($"Stack: {e.StackTrace}");
    Console.WriteLine($"HelpLink: {e.HelpLink}");
    Console.WriteLine("\n-> Custom Data:");
    foreach (DictionaryEntry de in e.Data)
    {
        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
    }
    Console.WriteLine($"\n*******Out of exception logic*******");
}
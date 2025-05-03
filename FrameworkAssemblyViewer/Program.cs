using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

Console.WriteLine("***** The Framework Assembly Reflector App *****\n");
var displayName = "Microsoft.EntityFrameworkCore, Version=5.0.0.0, Culture=\"\", PublicKeyToken = adb9793829ddae60";
Assembly asm = Assembly.Load(displayName);
DisplayInfo(asm);
Console.WriteLine("Done!");

static void DisplayInfo(Assembly a)
{
    Console.WriteLine("***** Info about Assembly *****");
    Console.WriteLine($"Asm Version: {a.GetName().Version}");
    Console.WriteLine($"Asm Culture: {a.GetName().CultureInfo.DisplayName}");
    Console.WriteLine("\nHere are the public enums: ");
    Type[] types = a.GetTypes();
    var publicEnums =
        from pe in types
        where pe.IsEnum && pe.IsPublic
        select pe;
    foreach (var pe in publicEnums)
    {
        Console.WriteLine(pe);
    }
}
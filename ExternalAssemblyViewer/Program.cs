using System;
using System.Reflection;

Console.WriteLine("***** External Assembly Viewer *****");
do
{
    Console.WriteLine("Enter an assembly to evaluate");
    Console.WriteLine("or enter Q to quit: ");
    string asmName = Console.ReadLine();
    if (asmName.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    try
    {
        Assembly asm = Assembly.LoadFrom(asmName);
        DisplayTypesInAsm(asm);
    }
    catch
    {
        Console.WriteLine("Sorry, can't find an assembly");
    }
}
while (true);

static void DisplayTypesInAsm(Assembly asm)
{
    Console.WriteLine("***** Types in Assembly *****");
    Console.WriteLine("->{0}", asm.FullName);
    Type[] types = asm.GetTypes();
    foreach (Type t in types)
    {
        Console.WriteLine("Type: {0}", t);
    }
    Console.WriteLine();
}
using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using CarLibrary;

Console.WriteLine("***** Welcome to MyTypeViewer *****");
do
{
    Console.WriteLine("\nEnter a type name to evaluate");
    Console.WriteLine("or enter Q to quit: ");
    string typeName = Console.ReadLine();
    if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    try
    {
        Type t = Type.GetType(typeName);
        if (t == null && typeName.Equals("System.Console",
        StringComparison.OrdinalIgnoreCase))
        {
            t = typeof(System.Console);
        }
        Console.WriteLine();
        ListVariousStats(t);
        ListFields(t);
        ListProps(t);
        ListMethods(t);
        ListInterfaces(t);
    }
    catch
    {
        Console.WriteLine("Sorry, can't find type");
    }
}
while (true);

static void ListMethods(Type t)
{
    Console.WriteLine("****** Methods ******");
    MethodInfo[] mi = t.GetMethods();
    foreach (MethodInfo m in mi)
    {
        Console.WriteLine("->{0}", m.Name);
    }
    Console.WriteLine();
}
static void ListProps(Type t)
{
    Console.WriteLine("***** Properties *****");
    var propNames = from p in t.GetProperties() select p.Name;
    foreach (var name in propNames)
    {
        Console.WriteLine("->{0}", name);
    }
    Console.WriteLine();
}
static void ListFields(Type t)
{
    Console.WriteLine("***** Fields *****");
    var fieldNames = from f in t.GetFields() select f.Name;
    foreach (var name in fieldNames)
    {
        Console.WriteLine("->{0}", name);
    }
    Console.WriteLine();
}
static void ListInterfaces(Type t)
{
    Console.WriteLine("***** Interfaces *****");
    var ifaces = from i in t.GetInterfaces() select i;
    foreach (Type i in ifaces)
    {
        Console.WriteLine("->{0}", i.Name);
    }
}
// Просто ради полноты картины,
static void ListVariousStats(Type t)
{
    Console.WriteLine("***** Various Statistics *****");
    Console.WriteLine("Base class is: {0}", t.BaseType);
    // Базовый класс
    Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
    // Абстрактный?
    Console.WriteLine("Is type sealed? {0}", t.IsSealed);
    // Запечатанный?
    Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
    // Обобщенный?
    Console.WriteLine("Is type a class type? {0}", t.IsClass);
    // Тип класса?
    Console.WriteLine();
}

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

Console.WriteLine("***** Fun with the default AppDomain *****");
DisplayDADStats();
ListAllAssembliesInAppDomain();
LoadAdditionalAssembliesDiffetentContexts();
LoadAdditionalAssembliesSameContext();

static void DisplayDADStats()
{
    AppDomain defaultAD = AppDomain.CurrentDomain;
    Console.WriteLine($"Name of this domain: {defaultAD.FriendlyName}");
    Console.WriteLine($"ID of this domain: {defaultAD.Id}");
    Console.WriteLine($"Is this the default domain?: {defaultAD.IsDefaultAppDomain()}");
    Console.WriteLine($"Base directory of this domain: {defaultAD.BaseDirectory}");
    Console.WriteLine("Setup Information for this domain:");
    Console.WriteLine($"\tApplication Base: {defaultAD.SetupInformation.ApplicationBase}");
    Console.WriteLine($"\tTarget Framework: {defaultAD.SetupInformation.TargetFrameworkName}");
}
static void ListAllAssembliesInAppDomain()  
{
    // Получить доступ к домену приложения для текущего потока. 
    AppDomain defaultAD = AppDomain.CurrentDomain;
    // Извлечь все сборки, загруженные в стандартный домен приложения.
    Assembly[] loadedAssemblies = defaultAD.GetAssemblies();
    Console.WriteLine("***** Here are the assemblies loaded in {0} *****", defaultAD.FriendlyName);
    foreach (Assembly a in loadedAssemblies)
    {
        Console.WriteLine($"-> Name, Version: {a.GetName()}: {a.GetName().Version}");
    }
}
static void LoadAdditionalAssembliesDiffetentContexts()
{
    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");
    AssemblyLoadContext lc1 = new AssemblyLoadContext("NewContext1", false);
    var cl1 = lc1.LoadFromAssemblyPath(path);
    var c1 = cl1.CreateInstance("ClassLibrary1.Car");
    AssemblyLoadContext lc2 = new AssemblyLoadContext("NewContext2", false);
    var cl2 = lc2.LoadFromAssemblyPath(path);
    var c2 = cl2.CreateInstance("ClassLibrary1.Car");
    Console.WriteLine($"Assembly1 Equals(Assembly2) {cl1.Equals(cl2)}");
    Console.WriteLine($"Assembly1 == Assebly2 {cl1 == cl2}");
    Console.WriteLine($"Class1.Equals(Class2) {c1.Equals(c2)}");
    Console.WriteLine($"Class1 == Class2 {c1 == c2}");
}
static void LoadAdditionalAssembliesSameContext()
{
    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
    "ClassLibrary1.dll");
    AssemblyLoadContext lc1 = new AssemblyLoadContext(null, false);
    var cl1 = lc1.LoadFromAssemblyPath(path);
    var c1 = cl1.CreateInstance("ClassLibrary1.Car");
    var cl2 = lc1.LoadFromAssemblyPath(path);
    var c2 = cl2.CreateInstance("ClassLibrary1.Car");
    Console.WriteLine("*** Loading Additional Assemblies in Same Context ***");
    Console.WriteLine($"Assembly1.Equals(Assembly2) {cl1.Equals(cl2)}");
    Console.WriteLine($"Assembly1 == Assembly 2 {cl1 == cl2}");
    Console.WriteLine($"Class1.Equals(Class2) {c1.Equals(c2)}");
    Console.WriteLine($"Class1 == Class2 {c1 == c2}");
}
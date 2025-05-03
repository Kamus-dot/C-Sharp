using System;
using System.IO;
using System.Reflection;

Console.WriteLine("***** Fun With Late Binding *****");
Assembly a = null;
try
{
    a = Assembly.LoadFrom("CarLibrary");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    return;
}
if (a != null)
{
    CreateUsingLateBinding(a);
    InvokeMethodWithArgsUsingLateBinding(a);
}

static void CreateUsingLateBinding(Assembly asm)
{
    try
    {
        Type miniVan = asm.GetType("CarLibrary.MiniVan");
        object obj = Activator.CreateInstance(miniVan);
        Console.WriteLine(obj.ToString());
        Console.WriteLine("Created a {0} using late binding!", obj);
        MethodInfo mi = miniVan.GetMethod("TurboBoost");
        mi.Invoke(obj, null);
        // dynamic obj = Activator.CreateInstance(miniVan);
        // obj.TurboBoost(); - делает тоже самое    
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void InvokeMethodWithArgsUsingLateBinding(Assembly asm)
{
    try
    {
        Type sport = asm.GetType("CarLibrary.SportsCar");
        object obj = Activator.CreateInstance(sport);
        MethodInfo mi = sport.GetMethod("TurnOnRadio");
        mi.Invoke(obj, [true, 2]);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
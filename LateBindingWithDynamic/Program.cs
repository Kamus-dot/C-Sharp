using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;

AddWithReflection();

static void AddWithReflection()
{
    Assembly asm = Assembly.LoadFrom(@"C:\Users\Алексей\OneDrive\Документы\C#\MathLibrary\MathLibrary.dll");
    try
    {
        Type math = asm.GetType("MathLibrary.SimpleMath");
        object obj = Activator.CreateInstance(math);
        MethodInfo mi = math.GetMethod("Add");
        object[] args = { 10, 70 };
        Console.WriteLine("Result is: {0}", mi.Invoke(obj, args));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
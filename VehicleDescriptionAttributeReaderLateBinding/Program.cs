using System;
using System.Reflection;

Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
ReflectAttributesUsingLateBinding();

static void ReflectAttributesUsingLateBinding()
{
    try
    {
        object[] objs = null;
        Assembly asm = Assembly.LoadFrom("AttributedCarLibrary");
        Type vehicleDesc = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");
        PropertyInfo propDesc = vehicleDesc.GetProperty("Description");
        Type[] types = asm.GetTypes();
        foreach (Type t in types)
        {
            objs = t.GetCustomAttributes(vehicleDesc, false);
            foreach (object o in objs)
            {
                Console.WriteLine("-> {0}: {1}\n", t.Name, propDesc.GetValue(o, null));
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
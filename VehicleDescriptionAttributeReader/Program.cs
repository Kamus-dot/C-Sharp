using System;
using AttributedCarLibrary;

Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
ReflectOnAttributesUsingEarlyBinding();

static void ReflectOnAttributesUsingEarlyBinding()
{
    Type t = typeof(Winnebago);
    object[] customAtts = t.GetCustomAttributes(false);
    foreach(VehicleDescriptionAttribute v in customAtts)
    {
        Console.WriteLine("-> {0}\n", v.Description);
    }
    
}
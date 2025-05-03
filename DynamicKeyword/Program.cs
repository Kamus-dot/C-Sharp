using System;
using System.Data.SqlTypes;
using DynamicKeyword;

UseObjectVariable();
PrintString();
ChangeDynamicDataType();

static void UseObjectVariable()
{
    object o = new Person() { FirstName = "Mike", LastName = "Larson" };
    Console.WriteLine("Person's first name is: {0}", ((Person)o).FirstName);
}
static void PrintString()
{
    var s1 = "Greetings";
    object s2 = "From";
    dynamic s3 = "Minneapolis";
    Console.WriteLine("s1 is of type: {0}", s1.GetType());
    Console.WriteLine("s2 is of type: {0}", s2.GetType());
    Console.WriteLine("s3 is of type: {0}", s3.GetType());
}
static void ChangeDynamicDataType()
{
    dynamic t = "Hello";
    Console.WriteLine("t is of type: {0}", t.GetType());
    t = false;
    Console.WriteLine("t is of type: {0}", t.GetType());
    t = new List<int>();
    Console.WriteLine("t is of type: {0}", t.GetType());
}

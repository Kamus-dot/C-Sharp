using System;
using MyExtensionMethods;

Console.WriteLine("***** Fun With Extension Methods *****\n");
// В int появилась отличительная черта!
int myInt = 123456789;
myInt.DisplayDefiningAssembly();
// То же и в DataSet!
System.Data.DataSet d = new System.Data.DataSet();
d.DisplayDefiningAssembly();

Console.WriteLine("Value of my Int: {0}", myInt);
Console.WriteLine("Reversed digits in myInt: {0}", myInt.ReverseDigits());

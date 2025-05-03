using System;
using System.Collections.Generic;
using InterfaceExtensions;

Console.WriteLine("***** Extending Interface Compatible Types *****");
// System.Array реализует IEnumerable
string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but", "in", "a", "weird", "way", "fun!" };
data.PrintDataAndBeep();
Console.WriteLine();
List<int> myInts = new List<int>() { 10, 15, 20 };
myInts.PrintDataAndBeep();

using System;
using OverloadedOps;

Console.WriteLine("*****Fun With Overloaded Operators*****");
Point ptOne = new Point(100, 100);
Point ptTwo = new Point(40, 40);
Console.WriteLine($"PtOne = {ptOne}");
Console.WriteLine($"PtTwo = {ptTwo}");
Console.WriteLine($"PtOne + PtTwo = {ptOne + ptTwo}");
Console.WriteLine($"PtOne - PtTwo = {ptOne - ptTwo}");
Console.WriteLine($"150 - PtTwo = {150 - ptTwo}");

Point ptThree = new Point(90, 5);
Console.WriteLine($"ptThree = {ptThree}");
Console.WriteLine($"ptThree += ptTwo: {ptThree += ptTwo}");
Point ptFour = new Point(0, 500);
Console.WriteLine($"ptFour = {ptFour}");
Console.WriteLine($"ptFour -= ptThree: {ptFour -= ptThree}");

Point ptFive = new Point(1, 1);
Console.WriteLine($"ptFive = {ptFive}");
Console.WriteLine($"++PtFive: {++ptFive}");

Console.WriteLine($"ptOne == ptTwo: {ptOne == ptTwo}");
Console.WriteLine($"ptFour != ptTwo: {ptFour != ptTwo}");
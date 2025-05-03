using System;
using System.Threading;
using SimpleMultiThreadApp;

Console.WriteLine("***** The Amazing Thread App *****\n");
Console.WriteLine("Do you want [1] of [2] threads?");
string threadCount = Console.ReadLine();
Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "Primary";
Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing Main()");
Printer p = new Printer();
switch (threadCount)
{
    case "2":
        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
        backgroundThread.Name = "Secondary";
        // backgroundThread.IsBackground = true; - прервёт работы по окончании потока переднего плана 
        backgroundThread.Start();
        break;
    case "1":
        p.PrintNumbers();
        break;
    default:
        Console.WriteLine("I don't know what you want...you get 1 thread");
        goto case "1";
}
Console.WriteLine("I'm busy");


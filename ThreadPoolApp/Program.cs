using System;
using System.Threading;
using ThreadPoolApp;

Console.WriteLine("***** Fun With the .NET Core Runtime Thread Pool *****");
Console.WriteLine("Main thread started. ThreadID = {0}", Thread.CurrentThread.ManagedThreadId);
Printer p = new();
WaitCallback workItem = new(PrintTheNumbers);
for (int i = 0; i < 10; i++)
{
    ThreadPool.QueueUserWorkItem(workItem, p);
}
Console.WriteLine("All task queued");
static void PrintTheNumbers(object state)
{
    Printer task = (Printer)state;
    task.PrintNumbers();
}
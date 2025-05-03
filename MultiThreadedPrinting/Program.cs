using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using MultiThreadedPrinting;

Console.WriteLine("*****Synchronizing Threads*****");
Printer p = new();
// Создать 10 потоков, которые указывают на один
// и тот же метод того же самого объекта
Thread[] threads = new Thread[10];
for (int i = 0; i < 10; i++)
{
    threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
    {
        Name = $"Worker thread #{i}"
    };
}
foreach (Thread t in threads)
{
    t.Start();
}
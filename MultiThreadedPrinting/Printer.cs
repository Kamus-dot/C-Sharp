using System;
using System.Threading;
namespace MultiThreadedPrinting
{
    class Printer
    {
        public int intValIncrement = 0;
        public int intValPlus = 0;
        private object threadLock = new();
        public void PrintNumbers()
        {
            intValIncrement = Interlocked.Increment(ref intValIncrement);
            // Использовать в качестве маркера блокировки закрытый
            // член object
            lock (threadLock)
            {
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                Thread.CurrentThread.Name);
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(100 * r.Next(5));
                    Console.Write(i + " ");
                }
                intValPlus++;
                Console.WriteLine($" --- {intValPlus}");
                Console.WriteLine();
            }
        }
    }
}
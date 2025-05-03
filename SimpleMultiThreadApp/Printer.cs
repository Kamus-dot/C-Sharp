using System;
using System.Threading;
namespace SimpleMultiThreadApp
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("-> {0} is executing PrintNumbers()",
            Thread.CurrentThread.Name);
            Console.WriteLine("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }

}
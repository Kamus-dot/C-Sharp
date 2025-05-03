using System;
using System.Threading;

Console.WriteLine("***** Working with Timer type *****");
TimerCallback timeCB = new(PrintTime);
Console.WriteLine("Hit key to terminate...");
Timer t = new Timer(
    timeCB, // Объект делегата TimerCallback
    "Hello From C# 13.0",   // Информация для передачи в вызванный метод
                            // (null если информация отсутсвует)
    0,      // Период ожидания перед запуском (в миллисекундах)
    1000    // Интервал между вызовами (в миллисекундах)
    );
Console.ReadLine();
static void PrintTime(object state)
{
    Console.WriteLine("Time is {0}, Param is {1}", DateTime.Now.ToLongTimeString(),
    state.ToString());
}
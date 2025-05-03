using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using AddWithThreads;

AutoResetEvent _waitHandle = new(false);
Console.WriteLine("***** Adding with Thread objects *****");
Console.WriteLine("ID of thread in Main(): {0}", Thread.CurrentThread.ManagedThreadId);
AddParams ap = new(10, 10);
// делегат ParametrizedThreadStart может указывать на любой метод, 
// принимающий параметр типа System.Object
Thread t = new(new ParameterizedThreadStart(Add));
t.Start(ap);
// Ожидать, пока не поступит уведомление!
Console.WriteLine("Still executing in  the Main Thread");
_waitHandle.WaitOne();
Console.WriteLine("Other thread is done");

void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);
        // Сообщить другому потоку о том, что работа завершена. 
        _waitHandle.Set();
    }
}

using System;
namespace SimpleFinalize
{
    class MyResourceWrapper
    {
        ~MyResourceWrapper() => Console.Beep();
    }
}
using System;
using PublicDelegateproblem;

Console.WriteLine("***** Agh! No Encapsulation! *****\n");
Car myCar = new Car();
myCar.ListOfHandlers = CallWhenExploded;
myCar.Accelerate(10);
myCar.ListOfHandlers = CallHereToo;
myCar.Accelerate(10);
myCar.ListOfHandlers.Invoke("hee, hee, hee...");

static void CallWhenExploded(string msg)
{
    Console.WriteLine(msg);
}
static void CallHereToo(string msg)
{
    Console.WriteLine(msg);
}


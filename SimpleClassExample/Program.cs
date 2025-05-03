using System;
using SimpleClassExample;

Console.WriteLine("**********Fun with Class Types**********");
Car mycar = new Car(abc: "Hello");
mycar.PrintState();
Car State = new Car(a: 12, abc: "Empty");
State.PrintState();

Motorcycle mc = new Motorcycle("Hello");
mc.PopAWhily();
Console.WriteLine(mc.name);
Console.WriteLine();

Motorcycle bc = new Motorcycle(4);
Console.WriteLine(bc.name ?? "Empty");
bc.PopAWhily();
Console.WriteLine(bc.driverIntensity + "\n");

mycar.petName = "Henry";
mycar.currSpeed = 10;
for (int i = 0; i <= 10; i++)
{
    mycar.SpeedUp(5);
    mycar.PrintState();
}

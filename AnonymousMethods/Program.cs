using System;
using System.Collections.Concurrent;
using AnonymousMethods;

Console.WriteLine("***** Anonymous Methods *****\n");
int aboutToBlowCounter = 0;
Car c1 = new Car("Slugbag", 100, 10);
c1._AboutToBlow += static delegate
{
    // aboutToBlowCounter ++;
    Console.WriteLine("Eek! Going so fast!");
};
c1.AboutToBlow += delegate
{
    Console.WriteLine("Eek! Going too fast!");
};
c1._AboutToBlow += delegate (object sender, CarEventArgs e)
{
    aboutToBlowCounter++;
    Console.WriteLine("Message from Car: {0}", e.msg);
};
c1._Exploded += delegate (object sender, CarEventArgs e)
{
    aboutToBlowCounter++;
    Console.WriteLine("Fatal Message from Car: {0}", e.msg);
};
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
Console.WriteLine("AboutToBlow event has fired {0} times.", aboutToBlowCounter);
Console.WriteLine("***** Discards with Anonymous Mehtods *****");
Func<int, int, int> constant = delegate (int _, int _) { return 42; };
Console.WriteLine($"constant(3, 4) = {constant(3, 4)}");
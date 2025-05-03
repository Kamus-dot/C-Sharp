using System;
using System.Threading.Tasks.Dataflow;
using SimpleGC;

Console.WriteLine("******* Fun With System.GC ********");
Console.WriteLine($"Estimated bytes on heap: {GC.GetTotalMemory(false)}");
Console.WriteLine($"This OS has {GC.MaxGeneration + 1} object generation \n");
Car reftomyCar = new Car("Zippy", 100);
Console.WriteLine(reftomyCar.ToString());
Console.WriteLine($"Generation of reftomyCar is: {GC.GetGeneration(reftomyCar)}");
Console.WriteLine(GC.CollectionCount(0));
object[] tonsofobjects = new object[50000];
for (int i = 0; i < 50000; i++)
{
    tonsofobjects[i] = new object();
}
Console.WriteLine($"Estimated bytes on heap: {GC.GetTotalMemory(false)}");
Console.WriteLine("Forced garbage Collection");
GC.Collect(0, GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();
Console.WriteLine($"Generation of reftomyCar is: {GC.GetGeneration(reftomyCar)}");
if (tonsofobjects[9000] != null)
{
    Console.WriteLine($"Generation of tonsofobjects[9000] is: {GC.GetGeneration(tonsofobjects[9000])}");
}
else
{
    Console.WriteLine("tonsofobjects[9000] is no longer alive.");
}
Console.WriteLine($"Generation 0 was swapt {GC.CollectionCount(0)} times");
Console.WriteLine($"Generation 1 was swapt {GC.CollectionCount(1)} times");
Console.WriteLine($"Generation 2 was swapt {GC.CollectionCount(2)} times");
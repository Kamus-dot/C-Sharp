using System;
using SimpleFinalize;
Console.WriteLine("******** Fun With Finalizers *******");
Console.WriteLine("Hit return to create the objects ");
Console.WriteLine("then force the GC to invoke Finalize()");
// Нажмите клавишу <Enter>, чтобы создать объекты1
// и затем заставить сборщик мусора вызвать метод Finalize()
// В зависимости от мощности вашей системы
// вам может понадобиться увеличить эти значения.
CreateObjects(1_100_000);
// Искусственно увеличить уровень давления.
GC.AddMemoryPressure(2147483647);
GC.Collect(0, GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();
static void CreateObjects(int count)
{
    MyResourceWrapper[] tonsOfObjects = new MyResourceWrapper[count];
    for (int i = 0; i < count; i++)
    {
        tonsOfObjects[i] = new MyResourceWrapper();
    }
    tonsOfObjects = null;
}

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

CancellationTokenSource _cancelToken = new();
do
{
    Console.WriteLine("Press any key to start processing");
    Console.ReadKey();
    Console.WriteLine("Processing...");
    Task.Factory.StartNew(ProcessIntData);
    Console.WriteLine("Enter Q to quit: ");
    // Введите Q для выхода:
    string answer = Console.ReadLine();
    if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        _cancelToken.Cancel();
        break;
    }
    Console.ReadLine();
}
while (true);
void ProcessIntData()
{
    int[] source = Enumerable.Range(1, 10_000_000).ToArray();
    // Найти числа, для которых истинно условие num % 3 == 0,
    // и возвратить их в убывающем порядке
    int[] modThreeIsZero = null;
    try{
    modThreeIsZero = (from num in source
                            where num % 3 == 0
                            orderby num descending
                            select num).ToArray();
    Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
    }
    catch(OperationCanceledException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

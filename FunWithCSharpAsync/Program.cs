using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("Fun With Async ===>");
// await PrintNumbersAsync();
Thread thread = new(PrintNumbers);
thread.Start();
Console.WriteLine(DoWork());
Console.WriteLine(DoWorkAsync().Result);
Console.WriteLine("Amount of threads:" + ThreadPool.GetAvailableThreads);
string message1 = await DoWorkAsync().ConfigureAwait(false);
MethodReturningTaskOfVoidAsync().Wait();
// await MethodReturningTaskOfVoidAsync(); - тоже самое
Console.WriteLine("Amount of threads:" + ThreadPool.ThreadCount);
MethodReturningVoidAsync();
await ReturnAnInt();
Console.WriteLine("Amount of threads:" + ThreadPool.ThreadCount);
await MethodWithProblems(12, 3);
Console.WriteLine("Amount of threads:" + ThreadPool.ThreadCount);
await MultipleAwaits();
Console.WriteLine("Completed");
Console.WriteLine("Amount of threads:" + ThreadPool.ThreadCount);
Console.ReadLine();

static void PrintNumbers()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    for (int i = 0; i < 30; i++)
    {
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
}
static async Task PrintNumbersAsync()
{
    await foreach (var number in GenerateSequance())
    {
        Console.WriteLine(number);
    }
}
static async IAsyncEnumerable<int> GenerateSequance()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    for (int i = 0; i < 20; i++)
    {
        await Task.Delay(1000);
        yield return i;
    }
}

static string DoWork()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    Thread.Sleep(5000);
    return "Done with work! (not async)";
}

static async Task<string> DoWorkAsync()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    return await Task.Run(() =>
    {
        Thread.Sleep(5_000);
        return "Done with work!";
    });

}
static async Task MethodReturningTaskOfVoidAsync()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    await Task.Run(() =>
    {
        Thread.Sleep(4000);
    });
    Console.WriteLine("1-st Void method complete");
}
static async void MethodReturningVoidAsync()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    await Task.Run(() =>
    {
        Thread.Sleep(4000);
        Console.WriteLine("Fire and forget void method completed");
    });
}

static async Task MultipleAwaits()
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    var taskl = Task.Run(() =>
    {
        Thread.Sleep(2_000);
        Console.WriteLine("Done with first task!");
    });
    var task2 = Task.Run(() =>
    {
        Thread.Sleep(1_000);
        Console.WriteLine("Done with second task!");
    });
    var task3 = Task.Run(() =>
    {
        Thread.Sleep(1_000);
        Console.WriteLine("Done with third task!");
    });
    await Task.WhenAny(taskl, task2, task3);
}
// static async Task<string> MethodWithTryCatch()
// {
//     try
//     {
//         return "Hello";
//     }
//     catch (Exception ex)
//     {
//         await LogTheErrors();
//     }
//     finally
//     {
//         await DoMagicCleanUp();
//     }
// }
static async ValueTask<int> ReturnAnInt()
{
    await Task.Delay(1_000);
    return 5;
}
static async Task MethodWithProblems(int firstParam, int seconParam)
{
    Console.WriteLine("Thread Id: " + Thread.GetDomainID());
    Console.WriteLine("Enter");
    if (seconParam < 0)
    {
        Console.WriteLine("Bad data");
        return;
    }
    await actualImpletation();
    async Task actualImpletation()
    {
        await Task.Run(() =>
        {
            // Длительно выполняющийся метод.
            Thread.Sleep(4_000);
            Console.WriteLine("First Complete");
            // Вызвать еще один длительно выполняющийся метод,
            // который терпит неудачу из-за того, что значение 
            // второго параметра выходит за пределы допустимого
            // диапазона
            Console.WriteLine("Something bad happen!");
        }
        );
    }
}
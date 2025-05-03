using System;
using System.Linq;
using System.Net;
using System.Collections;
using System.Security.Cryptography;

Console.WriteLine("*****Fun With LINQ to Objects *****\n");
QueryOverStrings();
Console.WriteLine();
QueryOverStringsExtensionMethods();
Console.WriteLine();
QueryOverStringsLongHand();
Console.WriteLine();
QueryOverInts();
Console.WriteLine();
ImmediateExecution();
GetCountFromQuery();


static void QueryOverStrings()
{
    string[] currentVideoGames = {"Morrowind", "Uncharted2",
    "Fallout 3", "Daxter", "System Shock 2"};
    // Построить выражение запроса для нахождения элементов массива,
    // которые содержат пробелы.
    IEnumerable<string> subset =
    from g in currentVideoGames
    where g.Contains(" ")
    orderby g
    select g;
    ReflectOverQueryResult(subset);
    foreach (string s in subset)
    {
        Console.WriteLine("Item: {0}", s);
    }
}
static void QueryOverStringsExtensionMethods()
{
    string[] currentVideoGames = {"Morrowind", "Uncharted2",
    "Fallout 3", "Daxter", "System Shock 2"};
    IEnumerable<string> subset =
    currentVideoGames.Where(g => g.Contains(" "))
    .OrderBy(g => g).Select(g => g);
    ReflectOverQueryResult(subset, "Extension Methods");
    foreach (string s in subset)
    {
        Console.WriteLine($"Item: {s}");
    }
}
static void QueryOverStringsLongHand()
{
    string[] currentVideoGames = {"Morrowind", "Uncharted2",
    "Fallout 3", "Daxter", "System Shock 2"};
    List<string> subset = new List<string>();
    foreach (string s in currentVideoGames)
    {
        if (s.Contains(" "))
        {
            subset.Add(s);
            Console.WriteLine(s);
        }
    }
}
static void ReflectOverQueryResult(object resultSet,
string queryType = "Query Expressions")
{
    Console.WriteLine($"***** Info about your query using {queryType}");
    Console.WriteLine("resultSet is of a Type: {0}", resultSet.GetType().Name);
    Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
}
static void QueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 5, 8 };
    // Вывести только элементы меньше 10
    IEnumerable subset = from i in numbers where i < 10 select i;
    List<int> ints = new List<int>();
    foreach (int i in subset)
    {
        Console.WriteLine($"Item: {i} < 10");
    }
    ReflectOverQueryResult(subset);
    Console.WriteLine();
    numbers[0] = 4;
    foreach (var i in subset)
    {
        Console.WriteLine($"{i} < 10");
    }
}
static void ImmediateExecution()
{
    Console.WriteLine("Immediate Execution");
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    // Получить первый элемент в поряке последовательности
    int number = (from i in numbers select i).First();
    Console.WriteLine("First is {0}", number);
    // Получить первый элемент в порядке запроса
    number = (from i in numbers orderby i select i).First();
    Console.WriteLine("First is {0}", number);
    // Получить один элемент, который соответствует запросу.
    number = (from i in numbers where i > 30 select i).Single();
    Console.WriteLine("Single is {0}", number);
    try
    {
        // В случае возвращения более одного элемента генерируется исключение.
        number = (from i in numbers where i > 10 select i).Single();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeptions has occured: {e.Message}");
    }
    int[] subsetAsIntArray =
    (from i in numbers where i < 10 select i).ToArray<int>();
    List<int> subsetAsIntList =
    (from i in numbers where i < 10 select i).ToList<int>();
}
static void GetCountFromQuery()
{
    string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                                "Fallout 3", "Daxter", "System Shock 2"};
    int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();
    Console.WriteLine($"{numb} items honor the LINQ query.");
}
using System;
using System.Collections;
using System.Linq;

Console.WriteLine("***** LINQ Return Values *****\n");
IEnumerable<string> subset = GetStringSubset();
foreach (string item in subset)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (string item in GetStringSubsetAsArray())
{
    Console.WriteLine(item);
}

static IEnumerable<string> GetStringSubset()
{
    string[] colors = {"Light Red", "Green",
"Yellow", "Dark Red", "Red", "Purple"};
    // Обратите внимание, что subset является
    // совместимым с IEnumerable<string> объектом.
    IEnumerable<string> theRedColors =
    from c in colors where c.Contains("Red") select c;
    return theRedColors;
}
static string[] GetStringSubsetAsArray()
{
    string[] colors = {"Light Red", "Green", "Yellow", 
    "Dark Red", "Red", "Purple"};
    var theRedColors = from c in colors where c.Contains("Red") select c;
    return theRedColors.ToArray();
}

using System;
using System.Linq;
using System.Net;
using QueryExpressions;


QueryStringsWithOperators();
QueryStringsWithEnumerableAndLambdas();
QueryStringsWithEnumerableAndLambdas2();
QueryStringsWithAnnonymousMethods();
VeryComplexQueryExpression.QueryStringsWithRawDelegates();
static void QueryStringsWithOperators()
{
    Console.WriteLine("***** Usign Query Operators *****");
    string[] currentVideoGames = {"Morrowind", "Uncharted 2",
"Fallout 3", "Daxter", "System Shock 2"};
    var subset = from game in currentVideoGames
                 where game.Contains(" ")
                 orderby game
                 select game;
    foreach (string s in subset)
    {
        Console.WriteLine("Item: {0}", s);
    }
    Console.WriteLine();
}
static void QueryStringsWithEnumerableAndLambdas()
{
    Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
    string[] currentVideoGames = {"Morrowind", "Uncharted 2",
    "Fallout 3", "Daxter", "System Shock 2"};
    // Построить выражение запроса с использованием расширяющих методов,
    // представленных типу Array через тип Enumerable.
    var subset = currentVideoGames
    .Where(game => game.Contains(" "))
    .OrderBy(game => game)
    .Select(game => game);
    foreach (var game in subset)
    {
        Console.WriteLine("Item: {0}", game);
    }
    Console.WriteLine();
}
static void QueryStringsWithEnumerableAndLambdas2()
{
    Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
    string[] currentVideoGames = {"Morrowind", "Uncharted 2",
    "Fallout 3", "Daxter", "System Shock 2"};
    // Разбить на части,
    var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
    var orderedGames = gamesWithSpaces.OrderBy(game => game);
    var subset = orderedGames.Select(game => game);
    foreach (var game in subset)
    {
        Console.WriteLine("Item: {0}", game);
    }
    Console.WriteLine();
}
static void QueryStringsWithAnnonymousMethods()
{
    Console.WriteLine("***** Using Annonymous Methods *****");
    string[] currentVideoGames = {"Morrowind", "Uncharted 2",
    "Fallout 3", "Daxter", "System Shock 2"};
    // Постороить необходимые делегаты Func<>
    // с использованием анонимных методов.
    Func<string, bool> searchFilter =
    delegate (string game) { return game.Contains(" "); };
    Func<string, string> itemToProcess =
    delegate (string game) { return game; };
    // Передать делегаты в методы класса Enumerable.
    var subset = currentVideoGames.Where(searchFilter)
    .OrderBy(itemToProcess).Select(itemToProcess);
    // Вывести результаты.
    foreach (var game in subset)
    {
        Console.WriteLine("Item: {0}", game);
    }
    Console.WriteLine();
}


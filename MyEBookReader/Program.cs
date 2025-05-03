using System;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net;

string _theEBook = "";
GetBook();
Console.WriteLine("Downloading the book...");
Console.ReadLine();
void GetBook()
{
    WebClient wc = new WebClient();
    wc.DownloadStringCompleted += (s, eArgs) =>
    {
        _theEBook = eArgs.Result;
        Console.WriteLine("Downloading Complete.");
        GetStats();
    };
    wc.DownloadStringAsync(new Uri("https://www.gutenberg.org/cache/epub/1342/pg1342.txt"));
}
void GetStats()
{
    // Получить слова из электронной книги
    string[] words = _theEBook.Split(new char[]
    {' ', '\u000A', ',', '.', ':', ':', '-', '?', '/'},
    StringSplitOptions.RemoveEmptyEntries);
    // Найти 10 наиболее часто встречающихся слов.
    string[] tenMostCommon = null;
    // Получить самое длинное слово.
    string longestWord = string.Empty;
    Parallel.Invoke(
        () => 
        {
            // Найти 10 наиболее часто встречающихся слов.
            tenMostCommon = FindTenMostCommon(words);
        },
        () =>
        {   
            longestWord = FindLongestWord(words);
        });
    // Когда все задачи завершены, построить строку, показывающую
    // все статические данные в окне сообщений.
    StringBuilder bookStats = new("Ten Most Common Words are:\n");
    foreach (string s in tenMostCommon)
    {
        bookStats.AppendLine(s);
    }
    bookStats.AppendFormat("Longest word is: {0}", longestWord);
    bookStats.AppendLine();
    Console.WriteLine(bookStats.ToString(), "Book info");
}
string[] FindTenMostCommon(string[] words)
{
    var frequencyOrder = from word in words
                         where word.Length > 6
                         group word by word into g
                         orderby g.Count() descending
                         select g.Key;
    string[] commonWords = (frequencyOrder.Take(10)).ToArray();
    return commonWords;
}
string FindLongestWord(string[] words)
{
    return (from w in words orderby w.Length descending select w).FirstOrDefault();
}
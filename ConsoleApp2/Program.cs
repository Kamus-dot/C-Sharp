using System.Numerics;
using System;
using System.Runtime.InteropServices;
using System.Text;

string userMessage = string.Format("100000 in hex is {0:X}", 100000);
Console.WriteLine(userMessage);
DefaultDeclaration();
DataTypeFunctionality();
CharFunctionality();
ParseFromStringsWithTryParse();
UseDatesAndTimes();
EscapeChars();
StringEquality();
FunWithStringBuilder();
Console.WriteLine("**** Fun with type conversions ****");
// Сложить две переменный типа short и вывести результат
int numb1 = 6, numb2 = 10;
Console.WriteLine($"{numb1} + {numb2} = {Add(numb1, numb2)}");
Console.ReadLine();

static double Add(int x, int y)
{
    return x + y;
}

static void DefaultDeclaration()
{
    int MyINT = default;
    bool B1 = new();
    Console.WriteLine("{0}, {1}", MyINT, B1);
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
}
static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data type Functionality:");
    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    double num = new();
    Console.WriteLine($"{num}");
    Console.WriteLine();
}
static void CharFunctionality()
{
    Console.WriteLine("=> char type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
    char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
    char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}",
    char.IsPunctuation('?'));
    Console.WriteLine();
}
static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b); // Вывод значения b
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
        // Вывод стандартного значения b
    }
    string value = "True";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        // Преобразование входного значения в double потерпело неудачу
        // и переменной было присвоено стандартное значение.
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
    }
    Console.WriteLine();
}
static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");
    // Этот конструктор принимает год, месяц и день.
    DateTime dt = new DateTime(2015, 10, 17);
    // Какой это день месяца?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
    // Сейчас месяц декабрь.
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}",
    dt.IsDaylightSavingTime());
    // Этот конструктор принимает часы, минуты и секунды.
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);
    // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
}
static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:\a");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\"\a ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug ");
    // Добавить четыре пустых строки и снова выдать звуковой сигнал.
    Console.WriteLine("All finished.\n\n\n\a ");
    Console.WriteLine();
}
static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string si = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine(@$"si = {si}");
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Проверить строки на равенство.
    Console.WriteLine($"si == s2: {si == s2}");
    Console.WriteLine("si == Hello!: {0}", si == "Hello!");
    Console.WriteLine("si == HELLO!: {0}", si == "HELLO!");
    Console.WriteLine("si == hello!: {0}", si == "hello!");
    Console.WriteLine("si.Equals(s2): {0}", si.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}
static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("***** Fantastic Games ******");
    sb.Append("\n");
    sb.AppendLine("Half Life");
    sb.AppendLine("Morrowind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    
    Console.WriteLine();
}
Console.Beep();

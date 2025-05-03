// using System.Runtime.ExceptionServices;

Point point = new Point(12, 15);
var pointValues = point.Deconstruct();
Console.WriteLine($"X is : {pointValues.XPos}");
Console.WriteLine($"Y is : {pointValues.YPos}");
var values = (FirstLetter: "a", 34, 'd');
Console.WriteLine(values.GetType());
Console.WriteLine("=> Inferred Tuple Names");
var foo = new { Propl = "first", Prop2 = "second" };
var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a ?? 0}");
Console.WriteLine($"String is: {samples.b ?? "Empty string"}");
Console.WriteLine($"Boolean is: {samples.c}");
var (first, _, last) = SplitNames("Philip F Japikse");
Console.WriteLine($"{first}:{last}");
Console.WriteLine(GetQuadrantl(point));


static (int? a, string? b, bool? c) FillTheseValues()
{
    return (null, "Enjoy your string.", true);
}
static (string first, string middle, string last) SplitNames(string fullName)
{
    // Действия, необходимые для расщепления полного имени,
    return ("Philip", "F", "Japikse");
}

static string GetQuadrantl(Point p)
{
    return p.Deconstruct() switch
    {
        (0, 0) => "Origin",
        var (х, у) when х > 0 && у > 0 => "One",
        var (х, у) when х < 0 && у > 0 => "Two",
        var (х, у) when х < 0 && у < 0 => "Three",
        var (х, у) when х > 0 && у < 0 => "Four",
        var (_, _) => "Border",
    };
}

struct Point
{
    // Поля структуры,
    public int X;
    public int Y;
    // Специальный конструктор,
    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }
    public (int XPos, int YPos) Deconstruct() => (X, Y);
}


DataBaseReader dr = new DataBaseReader();
int? i = dr.GetIntFromBase();
Console.WriteLine(i.HasValue ? $"Value of 'i' is {i.Value}" : $"Value of 'i' is undefined");
bool? b = dr.GetBoolFromBase();
Console.WriteLine(b != null ? $"Value if 'b' is {b.Value}" : $"Value of 'b' is undefined");
int myData = dr.GetIntFromBase() ?? 100;
i ??= 10;
i ??= 12;
Console.WriteLine($"Value of 'i' is {i.Value}");
Console.WriteLine($"Value from myData: {myData}");
TesterMethod(null);

static void TesterMethod(string[]? strarr)
{
    Console.WriteLine($"You sent me {strarr?.Length ?? 0} arguments");
}

class DataBaseReader
{
    public int? numericvalue = null;
    public bool? boolvalue = true;
    public int? GetIntFromBase()
    {
        return numericvalue;
    }
    public bool? GetBoolFromBase()
    {
        return boolvalue;
    }
}

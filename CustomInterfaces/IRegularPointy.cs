namespace CustomInterfaces
{
    interface IRegularPointy : IPointy
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;
        // Статические члены также разрешены в версии C# 8.
        static string ExampleProperty { get; set; }
        static IRegularPointy() => ExampleProperty = "Foo";
    }
}

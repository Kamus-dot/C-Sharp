namespace MiInterfaceHierarchy
{
    class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing...");
        public int GetNumberOfSides() => 4;
        public void Paint() => Console.WriteLine("Painting...");
    }
}
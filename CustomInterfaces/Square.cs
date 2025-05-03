namespace CustomInterfaces
{
    class Square : Shape, IRegularPointy
    {
        public Square() { }
        public Square(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
        public byte Points => 4;
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
    }
}
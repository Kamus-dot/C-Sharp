namespace CustomInterfaces
{
    class ThreeDCircle : Circle, IDraw3D
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
        public void Draw3D() => Console.WriteLine("Drawing a circle in 3D!");
    }
}
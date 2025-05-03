namespace MiInterfaceHierarchy
{
    class Square : IShape
    {
        void IDrawable.Draw() {}
        void IPrintable.Draw() {}
        public int GetNumberOfSides() => 4;
        public void Paint() {}
    }
}
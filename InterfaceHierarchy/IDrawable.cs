namespace InterfaceHierarchy
{
    public interface IDrawable
    {
        void Draw();
        int TimeToDraw(int t)
        {
            return t;
        }
    }

    public interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
        new int TimeToDraw() => 15;
    }
    public class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing ...");
        }
        public void DrawInBoundingBox(int top, int left, int bottom,
        int right)
        {
            Console.WriteLine("Drawing in a box...");
        }
        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }
        public int TimeToDraw() => 11;
    }

}

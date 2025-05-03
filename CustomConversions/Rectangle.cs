using System;
using System.Security.Cryptography.X509Certificates;
namespace CustomConversions
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return $"[Width = {Width}, Height = {Height}]";
        }
        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle
            {
                Width = s.Length*2,
                Height = s.Length
            };
            return r;
        }
    }
}
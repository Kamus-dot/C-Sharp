using System;
using System.Numerics;
namespace CustomConversions
{
    public struct Square
    {
        public int Length { get; set; }
        public Square(int l) : this()
        {
            Length = l;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
        public override string ToString()
        {
            return $"[Length = {Length}]";
        }

        //Явное приведение класс Square

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square { Length = r.Height };
            return s;
        }
        public static explicit operator Square(int sideLength)
        {
            Square s = new Square { Length = sideLength };
            return s;
        }
        public static explicit operator int(Square s)
        {
            return s.Length;
        }
    }
}
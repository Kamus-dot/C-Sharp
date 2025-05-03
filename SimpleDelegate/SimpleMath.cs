using System;
namespace SimpleDelegate
{
    // Этот класс содержит методы, на которые
    // будет указывать BinaryOp.
    public class SimpleMath
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int SquateNumber(int a) => a * a;
    }
}
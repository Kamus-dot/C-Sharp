using System;
namespace UnsafeCode
{
    // Эта структрура целиком является небезопасной и может
    // использоваться только в небезопасном контексте
    unsafe struct Node
    {
        public int Value;
        public Node* Left;
        public Node* Right;
    }
    // Эта структура безопасна, но члены Node2* - нет
    // Формально извне небезопасного контекста можно
    // обращаться к Value, но не к Right и Left.
    public struct Node2
    {
        public int Value;
        public unsafe Node2* Left;
        public unsafe Node2* Right;
    }
}

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenericPoint
{
    // Обобщенная структура Point,
    public struct Point<T>
    {
        // Обобщенные данные состояния,
        private T _xPos;
        private T _yPos;
        // Обобщенный конструктор,
        public Point(T xVal, T yVal)
        {
            _xPos = xVal;
            _yPos = yVal;
        }
        // Обобщенные свойства,
        public T X
        {
            get => _xPos;
            set => _xPos = value;
        }
        public T Y
        {
            get => _yPos;
            set => _yPos = value;
        }
        public override string ToString() => $"[{_xPos}, {_yPos}]";
        // Сбросить поля в стандартное значение параметра типа.
        // Ключевое слово default в языке C# перегружено .
        // При использовании с обобщениями оно представляет
        // стандартное значение параметра типа.
        public void ResetPoint()
        {
            _xPos = default(T);
            _yPos = default(T);
        }
    }
    class Check<K, T> where T : class, ICloneable, new()
    where K : struct, IComparable<T>
    {
        public int Int { get; set; }
        public Check(int a)
        {
            Int = a;
        }
    }

}
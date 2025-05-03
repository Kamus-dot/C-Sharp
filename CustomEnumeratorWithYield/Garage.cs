using System.Collections;

namespace CustomEnumeratorWithYield
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        int position = -1;
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }
        public IEnumerator GetEnumerator()
        {
            // Ошибка срабатывает только при срабатывании метода MoveNext(), но в данной ситуации
            // она срабатывает незамедлительно (из-за локальной функции(почему точно не могу сказать)).
            throw new Exception("This won't be called");
            return Actuallmplementation();
            // Локальная функция и фактическая реализация IEnumerator.
            IEnumerator Actuallmplementation()
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                    yield return carArray[1]; 
                }
                // yield - именованный итератор
            }
        }

    }
}
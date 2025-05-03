namespace CustomInterfaces
{
    public abstract class CloneableType
    {
        // Поддерживать этот "Полиморфный интерфейс"
        // могут только производные типы.
        // Классы в других иерархиях не имеют доступа 
        // к данному абстрактному члену.
        public abstract object Clone();
    }
    public interface ICloneable 
    {
        object Clone();
    }
}
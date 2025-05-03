namespace CustomInterfaces
{
    // Абстрактный базовый класс иерархии,
    abstract class Shape
    {
        protected Shape(string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }
        public abstract void Draw();
    }
}
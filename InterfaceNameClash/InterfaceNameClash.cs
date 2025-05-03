namespace InterfaceNameClash
{
    interface IDrawToForm
    {
        void Draw();
    }
}

namespace InterfaceNameClash
{
    interface IDrawMemory
    {
        void Draw();
    }
}

namespace InterfaceNameClash
{
    interface IDrawToPrinter
    {
        void Draw();
    }
}
namespace InterfaceNameClash
{
    class Octagon : IDrawMemory, IDrawToForm, IDrawToPrinter
    {
        public void Draw() => Console.WriteLine("Вот хз что происходит, и как совместить все члены в одной переменной");
        void IDrawMemory.Draw() => Console.WriteLine("Drawing to memory");
        void IDrawToForm.Draw() => Console.WriteLine("Drawing to form");
        void IDrawToPrinter.Draw() => Console.WriteLine("Drawing to printer");
    }
}
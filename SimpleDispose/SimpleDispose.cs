using System;
namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        // После окончания работы с объектом пользователь
        // объекта должен вызывать этот метод,
        public void Dispose()
        {
            // Очистить неуправляемые ресурсы...
            // Освободить другие освобождаемые объекты, содержащиеся внутри.
            // Только для целей тестирования.
            Console.WriteLine("******* In Dispose *******");
        }
        public static void UsingDeclaration()
        {
            // Эта переменная будет находиться в области видимости
            // вплоть до конца метода.
            using var rw = new MyResourceWrapper();
            // Сделать что-нибудь.
            Console.WriteLine("About to dispose.");
            // В этой точке переменная освобождается.
        }
    }
}
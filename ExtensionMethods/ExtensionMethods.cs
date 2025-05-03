using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
namespace MyExtensionMethods
{
    static class MyExtensions
    {
        // Этот метод позволяет объекту любого типа
        // отобразить сборку, в которой он определён.
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here: => {Assembly.GetAssembly(obj.GetType()).GetName().Name}\n");
        }
        // Этот метод позволяет любому целочисленному значению изменить порядок 
        // следования десятичных цифр на обратный.
        // Например, для 56 возвратится 65
        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }

    }
}


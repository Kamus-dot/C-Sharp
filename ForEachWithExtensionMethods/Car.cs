using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
namespace ForEachExtensionMethods
{
    class Car
    {
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        // Конструкторы
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
    }
}
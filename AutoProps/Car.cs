using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
namespace AutoProps
{
    class Car
    {
        public string? PetName { get; set; }
        public int Speed { get; set; }
        public string? Color { get; set; }
        public void DisplayStats()
        {
            Console.WriteLine($"Car Name: {PetName}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Garage
    {
        public int NumberofCats { get; } = 1;
        public Car MyAuto { get; set; } = new Car();
        public Garage()
        {
            MyAuto = new Car();
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberofCats = number;
        }
    }
    
}
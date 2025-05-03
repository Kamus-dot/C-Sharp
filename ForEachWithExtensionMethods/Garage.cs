using System;
namespace ForEachExtensionMethods
{
    class Garage
    {
        public Car[] CarsinGarage {get; set;}
        public Garage()
        {
            CarsinGarage = new Car[4];
            CarsinGarage[0] = new Car("Rusty", 30);
            CarsinGarage[1] = new Car("Clunker", 50);
            CarsinGarage[2] = new Car("Zippy", 30);
            CarsinGarage[3] = new Car("Fred", 30);
        }
    }
    
}
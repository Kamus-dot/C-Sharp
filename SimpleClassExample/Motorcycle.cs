using System;
namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string? name;
        public void PopAWhily()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee, Haeeeew!");
            }
        }
        public Motorcycle(int intensity) : this(intensity, null)
        {
            Console.WriteLine("This ctor is taking int");
        }
        public Motorcycle(string? name) : this(intensity: 12, name)
        {
            Console.WriteLine("This ctor is taking string");
        }
        public Motorcycle(int intensity, string? name)
        {
            Console.WriteLine("Operations in main constructor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            this.name = name;
        }
    }
}
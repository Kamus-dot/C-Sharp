using System;
using System.ComponentModel;
using System.Data;
namespace SimpleClassExample
{
    class Car
    {
        public string? petName;
        public int currSpeed;
        public Car()
        {
            Console.WriteLine("");
        }
        public Car(int a = 0, string? abc = "")
        {
            petName = abc;
            currSpeed = a;
        }
        public void PrintState()
        {
            Console.WriteLine($"{petName} is going {currSpeed} MPH.");
        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
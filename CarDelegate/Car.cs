using System;
using System.Linq;
namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool _carIsDead;
        public Car() { }
        public Car(string name, int MaxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = MaxSp;
            PetName = name;
        }
        public delegate void CarEngineHandler(string msgFprCaller);
        private CarEngineHandler _listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers += methodToCall;
        }
        public void UnRegisterWithCarEngine (CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }
        public void Accelerate(int delta)
        {
            // Если этот автомобиль слома, то отправить сообщение об этом.
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Автомобиль почти сломан?
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
    }
}
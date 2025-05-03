using System;
namespace CarEvents
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
        public delegate void CarEngineHandler(object sender, string msgForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        public event EventHandler<CarEventArgs> _Exploded;
        public event EventHandler<CarEventArgs> _AboutToBlow;

        public void Accelerate(int delta)
        {
            // Если этот автомобиль слома, то отправить сообщение об этом.
            if (_carIsDead)
            {
                Exploded?.Invoke(this, "Sorry, this car is dead...");
                _Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead!!!"));
            }
            else
            {
                CurrentSpeed += delta;
                // Автомобиль почти сломан?
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    AboutToBlow?.Invoke(this, "Careful buddy! Gonna blow!");
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
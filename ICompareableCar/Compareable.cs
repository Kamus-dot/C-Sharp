using System;

namespace CompareableCar;

class Radio
{
    public void TurnOn(bool on)
    {
        Console.WriteLine(on ? "Jamming. . ." : "Quiet time. .  .");
    }
}

class Car : IComparable
{
    // Константа для представления максимальной скорости,
    public const int MaxSpeed = 100;
    // Свойства автомобиля.
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";
    // He вышел ли автомобиль из строя?
    private bool _carIsDead;
    // В автомобиле имеется радиоприемник,
    private readonly Radio _theMusicBox = new Radio();
    public int CarID { get; set; }
    public Car(string name, int currSp, int id)
    {
        CurrentSpeed = currSp;
        PetName = name;
        CarID = id;
    }
    // Конструкторы,
    public Car() { }
    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }
    public void CrankTunes(bool state)
    {
        // Делегировать запрос внутреннему объекту.
        _theMusicBox.TurnOn(state);
    }
    // Проверить, не перегрелся ли автомобиль,
    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Console.WriteLine("{0} is out of order...", PetName);
        }
        else
        {
            CurrentSpeed += delta;
            if (CurrentSpeed >= MaxSpeed)
            {
                CurrentSpeed = 0;
                _carIsDead = true;
                throw new Exception($"{PetName} has overheated")
                {
                    HelpLink = "http://www.CarsRUs.com",
                    Data =
                    {
                        {"TimeStamp", $"The car exploaded at {DateTime.Now}"},
                        {"Cause", "You have a lead roof."}
                    }
                };
            }
            else
            {
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }

    int IComparable.CompareTo(object? obj)
    {
        if (obj is Car temp)
        {
            return this.CarID.CompareTo(temp.CarID);
        }
        throw new ArgumentException("Parameter is not a Car!");
        // Параметр не является объектом типа Саг!
    }
}


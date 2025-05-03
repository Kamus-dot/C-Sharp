using System;
namespace FunWithRecords
{
    class Car
    {
        public string? Mike { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public Car() { }
        public Car(string? mike, string? model, string? color)
        {
            Mike = mike;
            Model = model;
            Color = color;
        }
    }
    record CarRecord
    {
        public string? Mike { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public CarRecord() { }
        public CarRecord(string? mike, string? model, string? color)
        {
            Mike = mike;
            Model = model;
            Color = color;
        }

    }
}

using System;
namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public Point() { }
        // Переопределить Object.ToString()
        public override string ToString() => $"X = {X}, Y = {Y}, Name = {desc.PetName}\nID = {desc.PointID}";

        public object Clone()
        // => this.MemberwiseClone();
        {
            return new Point(this.X, this.Y);
        }
    }

    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
    }
}
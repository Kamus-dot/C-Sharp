using System;
namespace ImplicitAndExplicitConversions
{
    class Base
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X: {this.X}, Y: {this.Y}";
        }
    }
    class Derived : Base
    {
        public int Z { get; set; }
        public override string ToString()
        {
            return $"X: {this.X}, Y: {this.Y}, Z: {this.Z}";
        }
    }
}
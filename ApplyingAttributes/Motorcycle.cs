using System;
using System.Text.Json.Serialization;
namespace ApplyingAttributes
{
    public class Motorcycle
    {
        [JsonIgnore]
        public float weightOfCurrentPassengers;
        // Эти поля остаются сериализируемыми. 
        public bool hasRadioSystem;
        public bool hasHeadSet;
        public bool hasSissyBar;
    }
}
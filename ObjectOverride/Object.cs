using System;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string SSN { get; } = "";
        public int Age { get; set; }
        public Person(string fName, string lName, int personAge, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
            SSN = ssn;
        }
        public Person() { }

        public override string ToString()
            => $"[First Name: {FirstName}; LastName: {LastName}; Age: {Age}]";
        public override bool Equals(object? obj)
        {
            if (!(obj is Person temp))
            {
                return false;
            }
            if (temp.FirstName == this.FirstName
            && temp.LastName == this.LastName
            && temp.Age == this.Age)
            {
                return true;
            }
            return false;
        }

        // Больше нет необходимости приводить obj к типу Person,
        // т.к. у всех типов имеется метод ToStringO .
        // public override bool Equals(object obj)
        // => obj?.ToString() == ToString();
        public override int GetHashCode() 
        => SSN.GetHashCode();
        
    }

}
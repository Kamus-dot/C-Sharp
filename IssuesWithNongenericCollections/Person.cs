using System.Collections;
namespace IssuesWithNongenericCollections
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        // Приведение для вызывающего кода.
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        // Вставка только объектов Person.
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        public void ClearPeople()
        { 
            arPeople.Clear();
        }
        public int Count { get { return arPeople.Count; } }
        // Поддержка перечисления с помощью foreach.
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }

}
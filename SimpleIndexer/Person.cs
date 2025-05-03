using System.Collections;
namespace SimpleIndexer
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

        public Person this[int index]
        {
            get => (Person)arPeople[index];
            set => arPeople.Insert(index, value);
        }
    }
    public class PersonCollectionStringIndexer : IEnumerable
    {
        private Dictionary<string, Person> listPeople =
        new Dictionary<string, Person>();
        // Этот индексатор возвращает объект лица на основе строкового индекса.
        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }
        public void ClearPeople()
        {
            listPeople.Clear();
        }
        public int Count => listPeople.Count;
        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();
    }
}


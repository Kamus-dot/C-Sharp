using System;
using System.Collections.Generic;
using FunWithGenericCollections;

// UseGenericList();
// UseGenericStack();
// UseGenericQueue();
// UseSortedSet();
UseDictionary();

static void UseGenericList()
{
    // Создать список объектов Person и заполнить его с помощью
    // синтаксиса инициализации объектов и коллекции.
    List<Person> people = new List<Person>()
        {
        new Person {FirstName= "Homer", LastName="Simpson", Age=47},
        new Person {FirstName= "Marge", LastName="Simpson", Age=45},
        new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
        new Person {FirstName= "Bart", LastName="Simpson", Age=8}
        };
    // Вывести количество элементов в списке.
    Console.WriteLine("Items in list: {0}", people.Count);
    // Выполнить перечисление по списку,
    foreach (Person p in people)
        Console.WriteLine(p);
    // Вставить новый объект Person.
    Console.WriteLine("\n->Inserting new person.");
    people.Insert(2, new Person
    {
        FirstName = "Maggie",
        LastName = "Simpson",
        Age = 2
    });
    Console.WriteLine("Items in list: {0}", people.Count);
    // Скопировать данные в новый массив.
    Person[] arrayOfPeople = people.ToArray();
    foreach (Person p in arrayOfPeople) // Вывести имена
    {
        Console.WriteLine("First Names: {0}", p.FirstName);
    }
}
static void UseGenericStack()
{
    Stack<Person> stackOfPeople = new();
    stackOfPeople.Push(new Person
    {
        FirstName = "Homer",
        LastName = "Simpson",
        Age = 47
    });
    stackOfPeople.Push(new Person
    {
        FirstName = "Marge",
        LastName = "Simpson",
        Age = 45
    });
    stackOfPeople.Push(new Person
    {
        FirstName = "Lisa",
        LastName = "Simpson",
        Age = 9
    });
    // Просмотреть верхний элемент, вытолкнуть его и просмотреть снова.
    Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    try
    {
        Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
        Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("\nError! {0}", ex.Message); // Ошибка! Стек пуст.
    }
}
static void UseGenericQueue()
{
    // Создать очередь из трех человек.
    Queue<Person> peopleQ = new();
    peopleQ.Enqueue(new Person
    {
        FirstName = "Homer",
        LastName = "Simpson",
        Age = 47
    });
    peopleQ.Enqueue(new Person
    {
        FirstName = "Marge",
        LastName = "Simpson",
        Age = 45
    });
    peopleQ.Enqueue(new Person
    {
        FirstName = "Lisa",
        LastName = "Simpson",
        Age = 9
    });
    // Заглянуть, кто первый в очереди.
    Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
    // Удалить всех из очереди.
    GetCoffee(peopleQ.Dequeue());
    GetCoffee(peopleQ.Dequeue());
    GetCoffee(peopleQ.Dequeue());
    // Попробовать извлечь кого-то из очереди снова,
    try
    {
        GetCoffee(peopleQ.Dequeue());
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine("Error! {0}", e.Message); //Ошибка! Очередь пуста.
    }
    // Локальная вспомогательная функция,
    static void GetCoffee(Person p)
    {
        Console.WriteLine("{0} got coffee!", p.FirstName);
    }
    // Здесь Метод Dequeue возвращает тип значений Person, поэтому метод GetCoffee принимает именно Person
}
static void UseSortedSet()
{
    // Создать несколько объектов Person с разными значениями возраста.
    SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
        {
        new Person {FirstName= "Homer", LastName="Simpson", Age=47},
        new Person {FirstName= "Marge", LastName="Simpson", Age=45},
        new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
        new Person {FirstName= "Bart", LastName="Simpson", Age=8}
        };
    // Обратите внимание, что элементы отсортированы по возрасту.
    foreach (Person p in setOfPeople)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
    // Добавить еще несколько объектов Person с разными значениями возраста.
    setOfPeople.Add(new Person
    {
        FirstName = "Saku",
        LastName = "Jones",
        Age = 1
    });
    setOfPeople.Add(new Person
    {
        FirstName = "Mikko",
        LastName = "Jones",
        Age = 32
    });
    // Элементы по-прежнему отсортированы по возрасту.
    foreach (Person p in setOfPeople)
    {
        Console.WriteLine(p);
    }
}
static void UseDictionary()
{
    // Наполнить с помощью метода Add().
    Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
    peopleA.Add("Homer", new Person
    {
        FirstName = "Homer",
        LastName = "Simpson",
        Age = 47
    });
    peopleA.Add("Marge", new Person
    {
        FirstName = "Marge",
        LastName = "Simpson",
        Age = 45
    });
    peopleA.Add("Lisa", new Person
    {
        FirstName = "Lisa",
        LastName = "Simpson",
        Age = 9
    });
    // Получить элемент с ключом Homer.
    Person homer = peopleA["Homer"];
    Console.WriteLine(homer);
    // Наполнить с помощью синтаксиса инициализации.
    Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
{
{ "Homer", new Person { FirstName = "Homer",
LastName = "Simpson", Age = 47 } },
{ "Marge", new Person { FirstName = "Marge",
LastName = "Simpson", Age = 45 } },
{ "Lisa", new Person { FirstName = "Lisa",
LastName = "Simpson", Age = 9 } }
};
    // Получить элемент с ключом Lisa.
    Person lisa = peopleB["Lisa"];
    Console.WriteLine(lisa);
    // Наполнить с помощью синтаксиса инициализации словарей.
    Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
    {
        ["Homer"] = new Person
        {
            FirstName = "Homer",
            LastName = "Simpson",
            Age = 47
        },
        ["Marge"] = new Person
        {
            FirstName = "Marge",
            LastName = "Simpson",
            Age = 45
        },
        ["Lisa"] = new Person
        {
            FirstName = "Lisa",
            LastName = "Simpson",
            Age = 9
        }
    };
}

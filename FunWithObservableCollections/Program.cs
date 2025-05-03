using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using FunWithObservableCollections;
// Сделать коллекцию наблюдаемой
// и добавить в нее несколько объектов Person.
ObservableCollection<Person> people =
new ObservableCollection<Person>()
{
new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 },
};
// Привязаться к событию CollectionChanged.
people.CollectionChanged += people_CollectionChanged;

// Добавить новый элемент.
people.Add(new Person("Fred", "Smith", 32));
people.Add(new Person("Chack", "Smith", 30));
people.Add(new Person("Silver", "Smith", 36));
// Удалить элемент,
people.RemoveAt(0);


static void people_CollectionChanged(object sender,
NotifyCollectionChangedEventArgs e)
{
    // Выяснить действие, которое привело к генерации события.
    Console.WriteLine("Action for this event: {0}", e.Action);
    // Было что-то удалено.
    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the OLD items:"); // старые элементы
        foreach (Person p in e.OldItems)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine();
    }
    // Было что-то добавлено.
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        // Теперь вывести новые элементы, которые были вставлены.
        Console.WriteLine("Here are the NEW items:"); // Новые элементы
        foreach (Person p in e.NewItems)
        {
            Console.WriteLine(p);
        }
    }
}
// public enum NotifyCollectionChangedAction
// {
//     Add = 0,
//     Remove = 1,
//     Replace = 2,
//     Move = 3,
//     Reset = 4,
// }

using System;
using System.Collections.Generic;
using System.Data;
using SimpleIndexer;
// Индексаторы позволяют обращаться к элементам в стиле массива.
Console.WriteLine("****** Fun With Indexers ******");
PersonCollection myPeople = new PersonCollection();
// Добавить объекты с применением синтаксиса индексатора.
myPeople[0] = new Person("Homer", "Simpson", 40);
myPeople[1] = new Person("Marge", "Simpson", 38);
myPeople[2] = new Person("Lisa", "Simpson", 9);
myPeople[3] = new Person("Bart", "Simpson", 7);
myPeople[4] = new Person("Maggie", "Simpson", 2);
UseGenericListOfPeople();
// Получить и отобразить элементы, используя индексатор.
for (int i = 0; i < myPeople.Count; i++)
{
    Console.WriteLine("Person number: {0}", i); // номер лица
    Console.WriteLine("Name: {0} {1}",
    myPeople[i].FirstName, myPeople[i].LastName);
    Console.WriteLine("Age: {0}", myPeople[i].Age);
    Console.WriteLine();
    // имя и фамилия
    // возраст
}

Console.WriteLine();
PersonCollectionStringIndexer myPeopleStrings =
new PersonCollectionStringIndexer();
myPeopleStrings["Homer"] =
new Person("Homer", "Simpson", 40);
myPeopleStrings["Marge"] =
new Person("Marge", "Simpson", 38);
// Получить объект лица Homer и вывести данные.
Person homer = myPeopleStrings["Homer"];

MultiIndexerWithDataTable();

static void MultiIndexerWithDataTable()
{
    // Создать простой объект DataTable с тремя столбцами.
    DataTable myTable = new DataTable();
    myTable.Columns.Add(new DataColumn("FirstName"));
    myTable.Columns.Add(new DataColumn("LastName"));
    myTable.Columns.Add(new DataColumn("Age"));
    // Добавить строку в таблицу.
    myTable.Rows.Add("Mel", "Appleby", 60);
    //Использовать многомерный индексатор для вывода деталей первой строки
    Console.WriteLine("First Name: {0}", myTable.Rows[0][0]);
    Console.WriteLine("Last Name: {0}", myTable.Rows[0][1]);
    Console.WriteLine("Age : {0}", myTable.Rows[0][2]);
}

static void UseGenericListOfPeople()
{
    List<Person> myPeople = new List<Person>();
    myPeople.Add(new Person("Lisa", "Simpson", 9));
    myPeople.Add(new Person("Bart", "Simpson", 7));
    // Изменить первый объект лица с помощью индексатора.
    myPeople[0] = new Person("Maggie", "Simpson", 2);
    // Получить и отобразить каждый элемент, используя индексатор,
    for (int i = 0; i < myPeople.Count; i++)
    {
        Console.WriteLine("Person number: {0}", i);
        Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName,
        myPeople[i].LastName);
        Console.WriteLine("Age: {0}", myPeople[i].Age);
        Console.WriteLine();
    }
}

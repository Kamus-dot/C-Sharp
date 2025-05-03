using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using IssuesWithNongenericCollections;

Person person = new Person
{
    FirstName = "Bengamin",
    LastName = "Trorski",
    Age = 20
};

PersonCollection collect = new PersonCollection();
collect.AddPerson(person);
collect.AddPerson(new Person("Homer", "Simpson", 40));
collect.AddPerson(new Person("Marge", "Simpson", 38));
collect.AddPerson(new Person("Lisa", "Simpson", 9));
collect.AddPerson(new Person("Bart", "Simpson", 7));
collect.AddPerson(new Person("Maggie", "Simpson", 2));
Console.WriteLine(collect.Count);
foreach (Person pers in collect)
{
    Console.WriteLine(pers.ToString());
}

SimpleBoxUnboxOperation();
UseGenericList();

static void UseGenericList()
{
    // Этот объект List<> может хранить только объекты Person.
    List<Person> morePeople = new List<Person>();
    morePeople.Add(new Person("Frank", "Black", 50));
    Console.WriteLine(morePeople[0]);
    // Этот объект ListO может хранить только целые числа.
    List<int> moreInts = new List<int>();
    moreInts.Add(10);
    moreInts.Add(2);
    int sum = moreInts[0] + moreInts[1];
    // Ошибка на этапе компиляции! Объект Person
    // н е может быть добавлен в список элементов int!
    // morelnts.Add(new PersonO );
}

static void SimpleBoxUnboxOperation()
{
    // Создать переменную ValueType (int).
    int mylnt = 25;
    // Упаковать int в ссылку на object,
    object boxedlnt = mylnt;
    // Распаковать ссылку обратно в int.
    int unboxedlnt = (int)boxedlnt;
}


Person p = new Person { name = "Tom", age = 23 };
ChangePerson(p);

Console.WriteLine(p.name); // Alice
Console.WriteLine(p.age); // 23

ChangerefPerson(ref p);
Console.WriteLine(p.name); // Bill 
Console.WriteLine(p.age); // 45

void ChangePerson(Person person)
{
    // сработает
    person.name = "Alice";
    // сработает только в рамках данного метода
    person = new Person { name = "Bill", age = 45 };
    Console.WriteLine(person.name); // Bill
}
void ChangerefPerson(ref Person person)
{
    // сработает
    person.name = "Alice";
    // сработает
    person = new Person { name = "Bill", age = 45 };
}

class Person
{
    public string name = "";
    public int age;
}
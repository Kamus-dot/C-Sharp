using System;
using ObjectOverrides;

Console.WriteLine("Fun with System.Object \n");
// ПРИМЕЧАНИЕ: мы хотим, чтобы эти объекты были идентичными
// в целях тестирования методов Equals() и GetHashCode().
Person p1 = new Person("Homer", "Simpson", 50, "111-11-1111");
Person p2 = new Person("Homer", "Simpson", 50, "111-11-1111");
// Получить строковые версии объектов.
Console.WriteLine("p1.ToString() = {0}", p1.ToString());
Console.WriteLine("p2.ToString() = {0}", p2.ToString());
// Протестировать переопределенный метод Equals().
Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
// Протестировать хеш-коды.
// По-прежнему используется хеш-значение SSN.
Console.WriteLine("Same hash codes?: {0}",
p1.GetHashCode() == p2.GetHashCode());
Console.WriteLine();
// Изменить значение Age объекта p2 и протестировать снова.
p2.Age = 45;
Console.WriteLine("p1.ToString() = {0}", p1.ToString());
Console.WriteLine("p2.ToString() = {0}", p2.ToString());
Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
// По-прежнему используется хеш-значение SSN.
Console.WriteLine("Same hash codes?: {0}",
p1.GetHashCode() == p2.GetHashCode());

StaticMembersOfObject();

static void StaticMembersOfObject()
{
    // Статические члены System.Object.
    Person p3 = new Person("Sally", "Jones", 4, "111-000-111");
    Person p4 = new Person("Sally", "Jones", 4, "111-000-111");
    Console.WriteLine("P3 and P4 have same state: {0}",
    object.Equals(p3, p4));
    // РЗ и P4 имеют то же самое состояние
    Console.WriteLine("P3 and P4 are pointing to same object: {0}",
    object.ReferenceEquals(p3, p4));
    // РЗ и P4 указывают на тот же самый объект
}



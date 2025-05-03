using System;
using ImplicitAndExplicitConversions;

Base myBaseType;
// Неявное приведение производного класса к базовому
myBaseType = new Derived();
Console.WriteLine(myBaseType);
// Для сохранения ссылки на базовый класс в переменной
// приозводного класса требуется явное преобразование 
Derived myDerivedType = (Derived)myBaseType;
Console.WriteLine(myDerivedType);

// Неявное приведение производного класса к базовому.
Base myBaseType2 = new();
// Сгенерируется исключение InvalidCastException:
// Derived myDerivedType2 = (Derived)myBaseType2 as Derived;
// Исключения нет, myDerivedType2 равен null:
Derived myDerivedType2 = myBaseType2 as Derived;
Console.WriteLine(myDerivedType2);
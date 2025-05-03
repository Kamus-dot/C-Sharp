using System;
using System.IO;
using ProcessMultipleExceptions;
Console.WriteLine("***** Handling Multiple Exceptions ***** \n");
Car myCar = new Car("Rusty", 90);
try
{
    // Вызвать исключение выхода за пределы диапазона аргумента .
    myCar.Accelerate(10);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.Data);
    try
    {
        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
    }
    catch (Exception e2)
    {
        // Следующая строка приведет к ошибке на этапе компиляции,
        // т.к. InnerException допускает только чтение.
        // е.InnerException = е2;
        // Сгенерировать исключение, которое записывает новое
        // исключение, а также сообщение из первого исключения,
        Console.WriteLine(e2);
        throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    // Это код будет выполняться всегда независимо
    // от того,возникало исключение или нет.
    myCar.CrankTunes(false);
}
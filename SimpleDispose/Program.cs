using System;
using System.IO;
using SimpleDispose;
using (MyResourceWrapper rw = new MyResourceWrapper())
{
    Console.WriteLine("******* Fun With Dispose *******\n");
    // Создать освобождаемый объект и вызвать метод Dispose()
    // для освобождения любых внутренних ресурсов.
    if (rw is IDisposable)
    {
        rw.Dispose();
    }
    Console.WriteLine("Demonstrate using declarations");
    MyResourceWrapper.UsingDeclaration();
}


static void DisposeFileStream()
{
    FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);
    // Мягко выражаясь, сбивает с толку!
    // Вызовы этих методов делают одно и то же!
    fs.Close();
    fs.Dispose();
}




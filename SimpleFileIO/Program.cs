using System;
using System.IO;
Console.WriteLine("***** Simple IO with the File type *****");
// Измените это на папку на своей машине, к которой вы имеете доступ
// по чтению/записи или запускайте приложение от имени администратора,
var fileName = $@"С{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}TestTest{Path.DirectorySeparatorChar}Test.dat";
// Создать новый файл на диске С:.
FileInfo f = new FileInfo(fileName);
try
{
    FileStream fs = f.Create();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.Source);
}
// Использовать объект FileStream...
// Закрыть файловый поток.
// fs.Close();
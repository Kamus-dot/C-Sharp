using System;
using System.IO;
Console.WriteLine("***** Simple IO with the File type *****");

var fileName = $@"C:\TestTest\Test0.dat";
FileInfo f = new FileInfo(fileName);
FileStream fs = f.Create();
fs.Close();
using System;
using CarLibrary; //Библиотека

Console.WriteLine("****** C# CarLibrary Client App *****");
var internalClassInstance = new MyInternalClass(); // Возможно сделать благодаря атрибутам
SportsCar viper = new("Viper", 240, 40);
viper.TurboBoost();

MiniVan mv = new();
mv.TurboBoost();
Console.WriteLine("Done");


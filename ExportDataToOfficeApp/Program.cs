using System;
using System.Collections;
using System.Reflection;
using ExportDataToOfficeApp;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
List<Car> carsInStock = new List<Car>()
{
    new Car{Color="Green", Make="VW", PetName="Mary"},
    new Car{Color="Red", Make="Saab", PetName="Mel"},
    new Car{Color="Black", Make = "Ford", PetName="Hank"},
    new Car {Color="Yellow", Make="BMW", PetName="Davie"}
};

// Посмотреть код с Excel в браузере и попробывать постороить проект в .NET Framework;
try
{
    ExportToExcel(carsInStock);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void ExportToExcel(List<Car> carsInStock)
{
    Excel.Application excelApp = new();
    excelApp.get_Visible();
    Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.get_ActiveSheet();
    workSheet.Cells[1, "A"] = "Make";
    workSheet.Cells[1, "B"] = "Color";
    workSheet.Cells[1, "C"] = "Pet Name";
    int row = 1;
    // Составить все данные из List<Car> с ячейками электронной таблицы.
    foreach (Car c in carsInStock)
    {
        row++;
        workSheet.Cells[row, "A"] = c.Make;
        workSheet.Cells[row, "B"] = c.Color;
        workSheet.Cells[row, "C"] = c.PetName;
    }
    // Придать симпатичный вид табличным данным
    workSheet.Range["A1"].AutoFormat(
        Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
    workSheet.SaveAs(@"C:\Users\Алексей\OneDrive\Документы\C#\ExportDataToOfficeApp\Inventory.xlsx");
    excelApp.Quit();
    Console.WriteLine("The Inventory.xlsx file has been saved to your app folder");
}

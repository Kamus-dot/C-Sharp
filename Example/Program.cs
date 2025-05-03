using System;
using System.Reflection;
using ExportDataToOfficeApp;
using GemBox.Spreadsheet;

SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

// Create a new empty workbook.
var workbook = new ExcelFile();

// Add a worksheet to it.
var worksheet = workbook.Worksheets.Add("Sheet1");

// Write to the first cell.
worksheet.Cells["A1"].Value = "Hello World!";

// Save the workbook as Excel's XLSX file.
workbook.Save("Writing.xlsx");
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

// Инициализация стандартного массива.
int[] myArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// Инициализация обобщенного Listo с элементами int.
List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 3, 9 };
// Инициализация ArrayList числовыми данными.
ArrayList myList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 1, 0, 9 };

List<Point> myListOfPoints = new List<Point>
{
new Point { X = 2 , Y = 2 } ,
new Point { X = 3, Y = 3 } ,
new Point { X = 4 , Y = 4 }
};

foreach (var pt in myListOfPoints)
{
    Console.WriteLine(pt);
}



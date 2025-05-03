using System;
object[] kekw = { 1, 34, 53, 32, 3, 'c', '6', "Hello", new DateTime(1969, 11, 3) };
int[,] MyMatrix = new int[3, 4];
int[][] Teeth = new int[5][];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        MyMatrix[i, j] = j;
        Console.Write(MyMatrix[i, j] + " ");
    }
    Console.Write('\n');
}
Console.WriteLine();
for (int i = 0; i < Teeth.Length; i++)
{
    Teeth[i] = new int[2 * i + 3];
    for (int j = 0; j < Teeth[i].Length; j++)
    {
        Teeth[i][j] = i * j;
        Console.Write(Teeth[i][j] + " ");
    }
    Console.WriteLine();
}
for (int i = 1; i<=kekw.Length; i++)
{
    Index id = ^i;
    Console.Write(i==kekw.Length
    ? $"{kekw[id]} - {id}.\n"
    : $"{kekw[id]} - {id}, ");
}
Range r = 0..2;
foreach (int k in Teeth[2][r])
{
    Console.Write(k + " ");
}
Console.WriteLine();

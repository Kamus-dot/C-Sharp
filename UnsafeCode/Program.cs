using System;

Console.WriteLine("*****Calling method with unsafe code*****");
unsafe
{
    int myint = 10;
    SquareIntPointer(&myint);
    Console.WriteLine("Myint: {0}", myint);
    PrintValueAndAdress();
}
int myint2 = 11;
// SquareIntPointer(&myint2); Ошибка

Console.WriteLine("*****Calling method with unsafe code *****");
int i = 10, j = 20;
Console.WriteLine("\n***** Safe swap *****");
Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
SafeSwap(ref i, ref j);
Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);
Console.WriteLine("\n***** Unsafe swap *****");
Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
unsafe { UnsafeSwap(&i, &j); }
Console.WriteLine("Values after unsafe swap: i = {0}, j = {1}", i, j);

static unsafe void SquareIntPointer(int* MyIntPointer)
{
    *MyIntPointer *= *MyIntPointer;
}
static unsafe void PrintValueAndAdress()
{
    int myInt;
    // Определить указатель на int и присвоить ему адрес myInt.
    int* ptrToMyInt = &myInt;
    // Присвоить значение myInt, используя обращение через указатель
    *ptrToMyInt = 123;
    Console.WriteLine($"Value of myInt: {myInt}");
    Console.WriteLine($"Address of myInt {(int)&ptrToMyInt:X}");
}
static unsafe void UnsafeSwap(int* i, int* j)
{
    int temp = *i;
    *i = *j;
    *j = temp;
}
static void SafeSwap(ref int i, ref int j)
{
    int temp = i;
    i = j;
    j = temp;
}
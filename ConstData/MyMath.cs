using System;
using System.Diagnostics.Contracts;
namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14159265;
        public readonly double e;
        public MyMathClass()
        {
            e = 2.71828;
        }

    }
}
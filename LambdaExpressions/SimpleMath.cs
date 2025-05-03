using System;
using System.ComponentModel;
namespace LambdaExpressions
{
    class SimpleMath
    {
        internal delegate void MathMessage(string msg, int result);
        internal delegate string VerySimpleDelegate();
        private event MathMessage __mmDelegate;
        public void SetMathHandler(MathMessage target)
        {
            __mmDelegate = target;
        }
        public void Add(int x, int y)
        {
            __mmDelegate?.Invoke("Adding has completed!", x + y);
        }
    }
}
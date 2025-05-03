using System;
using static System.Console;
using static System.DateTime;
namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingsAccount(double balance)
        {
            Console.WriteLine("In public ctor!");
            currBalance = balance;
        }
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }
        public static void SetInterestRate(double newRate)
            => currInterestRate = newRate;
        public static double GetInterestRate()
            => currInterestRate;
        
    }

    static class TimeUntilClass
    {
        static public void PrintTime()
        => WriteLine(Now.ToShortTimeString());
        static public void PrintData()
        => WriteLine(Today.ToShortDateString());
    }
}
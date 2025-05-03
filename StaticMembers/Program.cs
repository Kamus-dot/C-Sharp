using System;
using StaticDataAndMembers;


SavingsAccount s1 = new SavingsAccount(50);
Console.WriteLine("Interest rate is {0}", SavingsAccount.GetInterestRate());
SavingsAccount.SetInterestRate(0.08);
Console.WriteLine("Interest rate is {0}", SavingsAccount.GetInterestRate());

SavingsAccount s2 = new SavingsAccount(10.455);
Console.WriteLine("Interest rate is {0}", SavingsAccount.GetInterestRate());

TimeUntilClass.PrintTime();
TimeUntilClass.PrintData();



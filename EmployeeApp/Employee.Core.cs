using System;
namespace EmployeeApp
{
    public partial class Employee
    {
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                => Pay += amount,
                _ => Pay += 0
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_empname}");
            Console.WriteLine($"ID: {_empId}");
            Console.WriteLine($"Pay: {_currPay}");
            Console.WriteLine($"Age: {_empAge}");
        }
    }
}
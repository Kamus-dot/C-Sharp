using System;
namespace Employees
{
    public partial class Employee
    {
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSsn;
        protected EmployeePayTypeEnum EmpPayType;
        public virtual void GiveBonus(float amount)
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
        public virtual void DisplayStats()
        {
            Console.WriteLine($"Job: {_payType}");
            Console.WriteLine($"Name: {_empname}");
            Console.WriteLine($"Age: {_empAge}");
            Console.WriteLine($"ID: {_empId}");
            Console.WriteLine($"Pay: {_currPay}");
            Console.WriteLine($"SocialSecurityNumber: {_empSSN}");
        }

        public static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
            if (emp is SalesPerson s)
            {
                Console.WriteLine("{0} made {1} sale(s)!", s.Name, s.SalesNumber);
                Console.WriteLine();
            }
            // Если Manager, тогда присвоить переменной m.
            else if (emp is Manager m)
            {
                Console.WriteLine("{0} had {1} stock options...",
                m.Name, m.StockOptions);
                Console.WriteLine();
            }
            else if (emp is var _)
            {
                // Некорректный тип сотрудника.
                Console.WriteLine("Unable to promote {0}. Wrong employee type",
                emp.Name);
                Console.WriteLine();

            }
        }
    }
}
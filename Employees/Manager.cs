using System.Diagnostics.Contracts;

namespace Employees
{
    class Hexagon
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a hexagon!");
            }
        }
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager(string fullName, int age, int empld, float currPay, string ssn, int numbOfOpts)
        : base(fullName, age, empld, currPay, ssn, EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numbOfOpts;
        }
        public Manager() { }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Numbers of Stock Options: {StockOptions}");
        }
    }
}
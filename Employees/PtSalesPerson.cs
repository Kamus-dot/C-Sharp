namespace Employees
{
    sealed class PtSalesPerson : SalesPerson
    {
        public PtSalesPerson(string fullName, int age, int empld, float currPay, string ssn, int numbOfSales)
        : base(fullName, age, empld, currPay, ssn, numbOfSales)
        {
            
        }
    }
}
namespace Employees
{
    public partial class Employee
        {
            protected BenefitPackage EmpBenefits = new BenefitPackage();
            // Открывает доступ к некоторому поведению, связанному со льготами,
            public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();
            // Открывает доступ к объекту через специальное свойство,
            public BenefitPackage Benefits
            {
                get { return EmpBenefits; }
                set
                {
                    EmpBenefits = value;
                    Console.WriteLine(value);
                }
            }
        }
    public class BenefitPackage
    {
        public double ComputePayDeduction()
        {
            return 12.5;
        }
    
    }
}
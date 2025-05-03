using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
namespace Employees
{
     abstract partial class Employee
    {
        private string? _empname;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private string _empSSN;
        private EmployeePayTypeEnum _payType;
        //Конструкторы
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "", EmployeePayTypeEnum.Salaried) { }
        
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }
        //Инкапсуляция
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }
        public string Name
        {
            get { return _empname; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name Length exceeds 15 characters");
                }
                else
                {
                    _empname = value;
                }
            }
        }
        public int ID
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public EmployeePayTypeEnum PayType
        {
            get { return _payType; }
            set { _payType = value; }
        }
        public string SocialSecurityNumber
        {
            get { return _empSSN; }
            private set { _empSSN = value; }
        }

        public string GetName() => _empname;
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empname = name;
            }
        }
    }
}
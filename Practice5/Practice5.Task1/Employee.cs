using System;

namespace Practice5.Task1
{
    internal class Employee
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }
        public int Salary { get; private set; }

        public virtual float CalculateBonus()
        {
            float cashback = Salary * 0.1f;

            return cashback;
        }
    }
}

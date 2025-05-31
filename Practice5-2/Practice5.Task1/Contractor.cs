using System;

namespace Practice5.Task1
{
    public class Contractor : Employee
    {
        public Contractor(string name, int salary, float hourlyRate) : base(name, salary)
        {
            HourlyRate = hourlyRate;
        }

        public float HourlyRate { get; private set; }

        public new float CalculateBonus(int hoursWorked)
        {
            float cashback = Salary * HourlyRate * hoursWorked;

            return cashback;
        }
    }
}

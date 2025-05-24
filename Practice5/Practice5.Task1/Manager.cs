using System;

namespace Practice5.Task1
{
    internal class Manager : Employee
    {
        public Manager(string name, int salary, int teamSize) : base(name, salary)
        {
            TeamSize = teamSize;
        }

        public int TeamSize { get; private set; }

        public override float CalculateBonus()
        {
            float cashback = base.CalculateBonus() * 2;

            if (TeamSize > 5)
            {
                cashback = base.CalculateBonus() * 2.05f;
            }

            return cashback;
        }
    }
}

using System;

namespace Practice5.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new("Bob", 1000);
            Manager manager = new("John", 2000, 5);

            Console.WriteLine($"Зарплата рабочего: {employee.Salary}, кэшбэк рабочего: {employee.CalculateBonus()}");
            Console.WriteLine($"Зарплата менеджера: {manager.Salary}, кэшбэк менеджера: {manager.CalculateBonus()}");
        }
    }
}

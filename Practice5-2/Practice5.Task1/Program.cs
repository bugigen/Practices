using System;

namespace Practice5.Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new("Bob", 1000);
            Manager manager = new("John", 2000, 7);
            Contractor contractor = new("Kenny", 3000, 0.01f);

            Console.WriteLine($"Зарплата рабочего: {employee.Salary}, кэшбэк рабочего: {employee.CalculateBonus()}");
            Console.WriteLine($"Зарплата менеджера: {manager.Salary}, кэшбэк менеджера: {manager.CalculateBonus()}");
            Console.WriteLine($"Зарплата контрактника: {contractor.Salary}, кэшбэк контрактника {contractor.CalculateBonus(8)}");
        }
    }
}

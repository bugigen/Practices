namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу \"Угадай число!\"");

            new GuessNumber().GetRandomNumber();
        }
    }

    public class GuessNumber()
    {
        public int GetRandomNumber()
        {
            Random random = new();

            int minNumber = 1;
            int maxNumber = 100;
            int number = random.Next(minNumber, maxNumber + 1);

            return number;
        }

        public int InputNumber()
        {
            Console.Write("Введи число: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
    }
}

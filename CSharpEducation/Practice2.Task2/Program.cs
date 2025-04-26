namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи символ для построения ёлочки: ");
            char symbol = char.Parse(Console.ReadLine());

            Console.Write("Введи высоту ёлочки: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i <= height; i++)
            {
                Console.Write(new string(' ', height - i));
                Console.Write(new string(symbol, i));
                Console.WriteLine();
            }
        }
    }
}


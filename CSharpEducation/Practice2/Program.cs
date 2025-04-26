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
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(symbol);
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }
        }
    }
}

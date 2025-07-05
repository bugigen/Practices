using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listStorage1 = new ListStorage<int>();
            listStorage1.Add(1);
            listStorage1.Add(2);
            listStorage1.Add(3);
            listStorage1.Add(4);
            listStorage1.Add(5);

            var listStorage2 = new ListStorage<string>();
            listStorage2.Add("one");
            listStorage2.Add("two");
            listStorage2.Add("three");
            listStorage2.Add("four");
            listStorage2.Add("five");
            listStorage2.Add("six");

            Console.WriteLine(listStorage1.Get(1));
            Console.WriteLine(listStorage2.Get(0));

            listStorage1.GetAllElements();
            Console.WriteLine();
            listStorage2.GetAllElements();

            Console.WriteLine();

            Console.WriteLine(listStorage1.Count);
            Console.WriteLine(listStorage2.Count);
        }
    }
}

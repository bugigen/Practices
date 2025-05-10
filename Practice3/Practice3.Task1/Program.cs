namespace Practice3.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Practice3.Task1!");

            new Student().ShowInfo();
        }
    }

    public class Student
    {
        private string _name = "John";
        private int _age = 21;

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {_name}, возраст: {_age}");
        }
    }
}

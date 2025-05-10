namespace Practice3.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Practice3.Task2!");

            Student student = new("John", 21, 0);

            student.ShowInfo();
        }

        public class Student
        {
            private string _name;
            private int _age;
            private int _averageGrade;

            public Student(string name, int age, int averageGrade)
            {
                _name = name;
                _age = age;
                AverageGrade = averageGrade;
            }

            public int AverageGrade
            {
                get => _averageGrade;

                set
                {
                    if (value < 1 || value > 5)
                    {
                        Console.WriteLine("WTF?!");
                        
                        throw new Exception("Средний балл должен быть в пределах от 1 до 5.");
                    }
                    else
                        _averageGrade = value;
                }
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Имя: {_name}, возраст: {_age}, средний балл: {AverageGrade}");
            }
        }
    }
}

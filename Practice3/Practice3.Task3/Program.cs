namespace Practice3.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Practice3.Task3!");

            Calculator calculatorOne = new(1, 2);

            //Calculator calculatorTwo = new(1, 0);

            calculatorOne.GetSum();
            calculatorOne.GetMultiplication();
            calculatorOne.GetSubstraction();
            calculatorOne.GetDividing();
        }
    }

    public class Calculator
    {
        private float _numberOne;
        private float _numberTwo;

        public Calculator(float numberOne, float numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }

        public float NumberOne { get; set; }
        public float NumberTwo { 
            get => _numberTwo;
            set
            {
                if (value == 0)
                    throw new Exception("Число не должно быть равно нулю.");
                else
                    _numberTwo = value;
            }
        }

        public void GetSum()
        {
            Console.WriteLine($"Сумма чисел {NumberOne} и {NumberTwo} = {NumberOne + NumberTwo}");
        }

        public void GetMultiplication()
        {
            Console.WriteLine($"Произведение чисел {NumberOne} и {NumberTwo} = {NumberOne * NumberTwo}");
        }

        public void GetSubstraction()
        {
            Console.WriteLine($"Разность чисел {NumberOne} и {NumberTwo} = {NumberOne - NumberTwo}");
        }

        public void GetDividing()
        {
            Console.WriteLine($"Деление чисел {NumberOne} и {NumberTwo} = {NumberOne / NumberTwo}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_OOP
{
    class Calculator
    {
        private double num1;
        private double num2;
        private double result;

        public void GetFirstNumber()
        {
            Console.Write("Введите первое число: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ошибка, необходимо ввести число");
                Console.Write("Введите первое число: ");
            }
        }

        public void GetSecondNumber()
        {

            Console.Write("Введите второе число: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка, необходимо ввести число");
                Console.Write("Введите второе число: ");
            }
        }

        public void Plus()
        {
            result = num1 + num2;
        }

        public void Minus()
        {
            result = num1 - num2;
        }

        public void Multiply()
        {
            result = num1 * num2;
        }

        public void Divide()
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка, нельзя делить на ноль");
                return;
            }
            result = num1 / num2;
        }

        public void Koreni()
        {
            if (num1 < 0)
            {
                Console.WriteLine("Ошибка, число не может быть отрецательным");
                return;
            }
            result = Math.Sqrt(num1);
        }

        public void DisplayResult()
        {
            Console.WriteLine("Результат: " + result);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            

            while (true)
            {
                calculator.GetFirstNumber();

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Квадратный корень");
                Console.WriteLine("6. Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка, необходимо ввести число");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        calculator.GetSecondNumber();
                        calculator.Plus();
                        calculator.DisplayResult();
                        break;

                    case 2:
                        calculator.GetSecondNumber();
                        calculator.Minus();
                        calculator.DisplayResult();
                        break;

                    case 3:
                        calculator.GetSecondNumber();
                        calculator.Multiply();
                        calculator.DisplayResult();
                        break;

                    case 4:
                        calculator.GetSecondNumber();
                        calculator.Divide();
                        calculator.DisplayResult();
                        break;

                    case 5:
                        calculator.Koreni();
                        calculator.DisplayResult();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Ошибка, неверная операция");
                        break;
                }
            }
        }
    }
}

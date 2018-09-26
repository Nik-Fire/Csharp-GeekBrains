using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковалёв_Н.ДЗ_Урок_3
{
    /// <summary>
    /// Структура для операций с комплексными числами
    /// </summary>
    struct Complex
    {
        public double value1;
        public double valuei;

        public Complex Substract(Complex x)
        {
            Complex y;
            y.value1 = value1 - x.value1;
            y.valuei = valuei - x.valuei;
            return y;
        }

        public string ConvToString()
        {
            return value1 + " + " + valuei + "i";
        }
    }

    /// <summary>
    /// Класс для операций с дробями
    /// </summary>
    class Fractions
    {
        private int num;
        private int denom;

        public Fractions ()
        {
            num = 0;
            denom = 0;
        }

        public Fractions(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
            if (denom == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
        }

        public Fractions Sum (Fractions x)
        {
            Fractions SumResult = new Fractions();
            int CD = denom * x.denom;
            SumResult.num = (num * x.denom) + (x.num * denom);
            SumResult.denom = CD;
            return SumResult;
        }

        public Fractions Sub (Fractions x)
        {
            Fractions SubResult = new Fractions();
            int CD = denom * x.denom;
            SubResult.num = (num * x.denom) - (x.num * denom);
            SubResult.denom = CD;
            return SubResult;
        }

        public Fractions Mult (Fractions x)
        {
            Fractions MultResult = new Fractions();
            MultResult.num = num * x.num;
            MultResult.denom = denom * x.denom;
            return MultResult;
        }

        public Fractions Div (Fractions x)
        {
            Fractions DivResult = new Fractions();
            DivResult.num = num * x.denom;
            DivResult.denom = denom * x.num;
            return DivResult;
        }

        public string Result()
        {
            if (num > denom) return ((num / denom) + " целых " + (num % denom) + "/" + denom);
            return (num + "/" + denom);
        }
    }

    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Выбрана Задача 1: \"Вычитание комплексных чисел\"");
                    Ex1();
                    break;
                case 2:
                    Console.WriteLine("Выбрана Задача 2: \"Подсчёт цифр в числе\"");
                    Console.Write("Введите число: ");
                    Ex2();
                    break;
                case 3:
                    Console.WriteLine("Выбрана Задача 3: \"Операции с дробями\"");
                    Ex3();
                    break;
            }
        }

        static void Ex1()
        {
            Complex firstNumb;
            firstNumb.value1 = 3;
            firstNumb.valuei = 4;

            Complex secondNumb;
            secondNumb.value1 = 2;
            secondNumb.valuei = 2;

            Complex result = firstNumb.Substract(secondNumb);
            Console.WriteLine(result.ConvToString());
            Console.ReadKey();
        }

        static void Ex2()
        {
            int a = 0;
            bool s;
            int x;
            do
            {
                s = int.TryParse(Console.ReadLine(), out x);
                if (s && IsOdd(x) && x > 0) a += x;
                else if (!s) Console.WriteLine("Ошибка ввода");
            }
            while (x != 0);

            Console.WriteLine($"Сумма всех введённых нечётных положительных чисел равна {a}");
            Console.ReadKey();
        }

        static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        static void Ex3()
        {
            Fractions FrOne = new Fractions (1, 5);
            Console.WriteLine($"\nПервая дробь: {FrOne.Result()}");

            Fractions FrTwo = new Fractions(3, 2);
            Console.WriteLine($"\nВторая дробь: {FrTwo.Result()}");

            Fractions result = new Fractions();

            Console.WriteLine("\nСумма:");
            result = FrOne.Sum(FrTwo);
            Console.WriteLine(result.Result());

            Console.WriteLine("\nРазность");
            result = FrOne.Sub(FrTwo);
            Console.WriteLine(result.Result());

            Console.WriteLine("\nПоизведение");
            result = FrOne.Mult(FrTwo);
            Console.WriteLine(result.Result());

            Console.WriteLine("\nЧастное");
            result = FrOne.Div(FrTwo);
            Console.WriteLine(result.Result());

            Console.ReadKey();
        }
    }
}

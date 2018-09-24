using System;

namespace Ковалёв_Н.ДЗ_Урок_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int caseSwitch = Convert.ToInt32 (Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Выбрана Задача 1: \"Наименьшее число\"");
                    Console.WriteLine("Введите три числа:");
                    Ex1(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Выбрана Задача 2: \"Подсчёт цифр в числе\"");
                    Console.Write("Введите число: ");
                    Ex2(long.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("Выбрана Задача 3: \"Сумма положительных нечетных чисел\"");
                    Console.WriteLine("Вводите числа, сумму которых хотите получить, затем введите 0 для подсчёта");
                    Ex3();
                    break;
                case 4:
                    Console.WriteLine("Выбрана Задача 4: \"Проверка логина/пароля\"");
                    Ex4();
                    break;
                case 5:
                    Console.WriteLine("Выбрана Задача 5: \"Индекс массы тела\"");
                    Ex5();
                    break;
                case 6:
                    Console.WriteLine("Выбрана Задача 6: \"Подсчёт хороших чисел от 1 до 100 000 000\"");
                    Ex6();
                    break;
                case 7:
                    Console.WriteLine("Выбрана Задача 7: \"Сумма чисел от a до b\"");
                    Ex7();
                    break;
            }
        }

        static void Ex1(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine($"Наименьшим числом является {a}");
            }
            else
            {
                if (b < c && b < a)
                {
                    Console.WriteLine($"Наименьшим числом является {b}");
                }
                else Console.WriteLine($"Наименьшим числом является {c}");
            }
            Console.ReadKey();
        }

        static void Ex2 (long a)
        {
            int counter = 0;
            while (a > 0)
            {
                a /= 10;
                counter++;
            }
            Console.WriteLine("В этом числе {0} цифр(ы)", counter);
            Console.ReadKey();
        }

        static void Ex3()
        {
            int a = 0;
            int b = 0;
            do
            {
                b = int.Parse(Console.ReadLine());
                if(IsOdd(b) && b > 0) a += b;
            }
            while (b != 0);

            Console.WriteLine($"Сумма всех введённых нечётных положительных чисел равна {a}");
            Console.ReadKey();

        }

        static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        static bool PasswordCheck(string log, string pas)
        {
            if (log == "root" && pas == "GeekBrains") return true;
            else return false;
        }

        static void Ex4()
        {
            string login;
            string password;
            int counter = 3;
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                counter--;
                if (PasswordCheck(login, password)) break;
                else
                {
                    if (counter <= 0) goto Fail;
                    Console.WriteLine($"Попробуйте ещё раз (осталось попыток: {counter})");
                }
            }
            while (counter > 0);

            ///Этот блок имитирует возможность продолжения работы в программе при верном вводе пароля, или же переход к её завершению в случае провала

            Console.WriteLine("Всё верно!");
            Console.WriteLine("Можно продолжить работу в программе");
            Console.ReadLine();
            goto Fin;

            Fail:
            Console.WriteLine("Число попыток исчерпано. Нажмите любую клавишу для завершения работы программы.");
            Console.ReadKey();
            Fin:;

        }

        static double BMI(int m, double h)
        {
            return m / (h * h);
        }

        static void Ex5()
        {
            Console.Write("Введите вашу массу (в килограммах): ");
            int mass = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш pocт (в метрах): ");
            double height = double.Parse(Console.ReadLine());
            double index = BMI(mass, height);
            Console.WriteLine("Ваш индекс массы тела равен {0:F2}", index);
            if (index > 24.99) Console.WriteLine($"Вам нужно похудеть на {index - 24.99:F2} килограмм");
            else if (index < 18.5) Console.WriteLine($"Вам нужно набрать {18.5 - index:F2} килограмм");
            else Console.WriteLine("Ваш вес в норме");

            Console.ReadKey();
        }

        static long Sum(int a)
        {
            int b = 0;
            while (a != 0)
            {
                b += a % 10;
                a /= 10;
            }
            return b;
        }

        static bool IsGood(int a)
        {
            return a % Sum(a) == 0;
        }

        static void Ex6()
        {
            DateTime start = DateTime.Now;
            int counter = 0;
            for (int i = 1; i <= 100000000; i++)
            {
                if (IsGood(i)) counter++;
            }
            Console.WriteLine($"Хороших чисел в этом диапазоне: {counter}");
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Выполнение данной задачи заняло {finish - start} секунд");
            Console.ReadKey();
        }

        static void Ex7()
        {
            Console.WriteLine("Введите первое число");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Все числа от первого до второго:");
            Loop(first, second);
            Console.ReadKey();
        }

        static void Loop (int a, int b)
        {
            Console.WriteLine($"{a}");
            if (a < b) Loop(a + 1, b);
        }
    }
}

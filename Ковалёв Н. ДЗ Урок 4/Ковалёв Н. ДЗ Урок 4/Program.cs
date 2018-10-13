using System;
using System.IO;

namespace Ковалёв_Н.ДЗ_Урок_4
{
    /// <summary>
    /// Класс для работы с одномерным массивом
    /// </summary>
    class MyArray
    {
        private int[] a;
        public MyArray(int size, int step)
        {
            a = new int[size];
            int n = 0;
            for(int i = 0; i < size; i++)
            {
                n += step;
                a[i] = n;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++) sum += a[i];
                return sum;
            }
        }

        public void Inverse ()
        {
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = -a[i];
            }
        }

        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * x;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for (int i = 1; i < a.Length; i++)
                {
                    if (max < a[i]) max = a[i];
                }
                for (int i = 1; i < a.Length; i++)
                {
                    if (max == a[i]) count++;
                }
                return count;
            }
        }

        public string ToStr()
        {
            string res = "";
            string next = "; ";
            foreach (int v in a)
            {
                res += v + next;
            }
            return res;
        }
    }

    struct Account
    {
        public string login;
        public string password;
        int[] a = new int[2];

        public void AccInfo ()
        {
            StreamReader sr = new StreamReader("C:\Users\1\Desktop\Programming\Курс C# Уровень 1\Урок 4\Ковалёв Н. ДЗ Урок 4\Логин.txt");
            for(int i = 0; i < 2; i++)
            {
                a[i] = sr.ReadLine;
            }
            login = a[0];
            password = a[1];
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
                    Console.WriteLine("Выбрана Задача 1: \"Пары, делимые на 3\"");
                    Ex1();
                    break;
                case 2:
                    Console.WriteLine("Выбрана Задача 2: \"Класс для работы с одномерным массивом\"");
                    Ex2();
                    break;
                case 3:
                    Console.WriteLine("Выбрана Задача 3: \"Запись логина/пароля из файла\"");
                    Ex3();
                    break;
            }
        }

        static void Ex1()
        {
            int[] pairs = new int [20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                pairs[i] = rnd.Next(-10000, 10000);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(pairs[i] + ", ");
            }

            int counter = 0;
            for (int i = 0; i < pairs.Length - 1; i++)
            {
                if (pairs[i] % 3 == 0 || pairs[i + 1] % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"\nКоличество пар, в которых хотя бы одно число делится на 3: {counter} штук");
            Console.ReadKey();
        }

        static void Ex2()
        {
            MyArray Arr1 = new MyArray(10, 2);
            Console.WriteLine("Изначальный массив");
            Console.WriteLine(Arr1.ToStr());
            Console.WriteLine("Сумма элементов");
            Console.WriteLine(Arr1.Sum);
            Arr1.Inverse();
            Console.WriteLine("Инверсированный массив");
            Console.WriteLine(Arr1.ToStr());
            Arr1.Multi(3);
            Console.WriteLine("Перемноженный массив");
            Console.WriteLine(Arr1.ToStr());
            Console.WriteLine("Количество максимальных членов массива");
            Console.WriteLine(Arr1.MaxCount);
            Console.ReadKey();
        }

        static void Ex3()
        {
            Account Acc = new Account();
            Acc.AccInfo();
            Console.WriteLine(Acc.login);
            Console.WriteLine(Acc.password);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковалёв_Н.ДЗ_Ч2_УР2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseWorker w1 = new FixPay(10000);
            Console.WriteLine(w1.AveragePay());
            BaseWorker w2 = new HourPay(322);
            Console.WriteLine(w2.AveragePay() + "\n");

            //Заполнение массива 

            w1.Workers = new BaseWorker[10];
            for (int i = 0; i < w1.Workers.Length / 2; i++)
            {
                w1.Workers[i] = new HourPay((50 * i) + 5000);
            }

            for (int i = w1.Workers.Length / 2; i < w1.Workers.Length; i++)
            { 
                w1.Workers[i] = new FixPay(500 * i);
            }

            //Отображение массива через foreach

            foreach (BaseWorker item in w1.Workers)
            {
                Console.WriteLine(item.Payment);
            }

            Console.WriteLine("\n");

            Array.Sort(w1.Workers);

            //Отображение массива через аналогичный метод

            w1.ShowWorkers();
        }
    }
}

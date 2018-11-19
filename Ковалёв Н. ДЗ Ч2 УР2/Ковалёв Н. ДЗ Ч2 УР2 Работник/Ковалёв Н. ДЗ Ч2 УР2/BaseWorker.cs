using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковалёв_Н.ДЗ_Ч2_УР2
{
    abstract class BaseWorker : IComparable 
    {
        public int Payment { get; set; }
        public BaseWorker[] Workers;

        public BaseWorker(int Payment)
        {
            this.Payment = Payment;
        }

        public abstract double AveragePay();

        public int CompareTo(object obj)
        {
            if (Payment > ((BaseWorker) obj).Payment) return 1;
            if (Payment < ((BaseWorker) obj).Payment) return -1;
            return 0;
        }

        public void ShowWorkers()
        {
            foreach (BaseWorker item in Workers)
            {
                Console.WriteLine(item.Payment);
            }
        }
    }
}

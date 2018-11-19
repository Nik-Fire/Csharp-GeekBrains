using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковалёв_Н.ДЗ_Ч2_УР2
{
    class HourPay : BaseWorker
    {
        public HourPay(int Payment) : base(Payment)
        {

        }

        public override double AveragePay()
        {
            return 20.8 * 8 * Payment;
        }
    }
}

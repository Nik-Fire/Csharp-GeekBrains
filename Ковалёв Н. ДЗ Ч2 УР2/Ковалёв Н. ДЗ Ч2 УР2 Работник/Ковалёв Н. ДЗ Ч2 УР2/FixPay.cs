using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковалёв_Н.ДЗ_Ч2_УР2
{
    class FixPay : BaseWorker
    {
        public FixPay(int Payment) : base(Payment)
        {

        }

        public override double AveragePay ()
        {
            return Payment;
        }
    }
}

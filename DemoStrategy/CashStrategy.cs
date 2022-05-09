using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class CashStrategy : PaymentStrategy
    {
        public override void PaymentMethod()
        {
            Console.WriteLine("Pay with cash");
        }
    }
}

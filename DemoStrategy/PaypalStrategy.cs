using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class PaypalStratefy : PaymentStrategy
    {
        public override void PaymentMethod()
        {
            Console.WriteLine("Pay with Paypal");
        }
    }
}

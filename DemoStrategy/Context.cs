using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Context
    {
        public PaymentStrategy strategy;
        public Context(PaymentStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.PaymentMethod();
        }
    }
}

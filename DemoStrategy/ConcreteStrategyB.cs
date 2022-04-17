using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Call Algorithm of ConcreteStrategyB");
        }
    }
}

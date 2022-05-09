using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new PaypalStratefy());
            context.ContextInterface();

            context = new Context(new CashStrategy());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}

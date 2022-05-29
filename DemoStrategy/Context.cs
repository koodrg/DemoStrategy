using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Context
    {
        public IConvertStrategy _strategy;
        public Context(IConvertStrategy strategy)
        {
            _strategy = strategy;
        }
        public Context() { }
        public void DoAlgorithm()
        {
            _strategy.ConvertFile();
        }
    }
}

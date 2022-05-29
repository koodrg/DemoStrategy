using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class GifStrategy : IConvertStrategy
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting file to gif");
            Console.WriteLine("...");
            Console.WriteLine("Convert complete");
            Console.WriteLine();
        }
    }
}

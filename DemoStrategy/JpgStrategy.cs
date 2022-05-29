using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class JpgStrategy : IConvertStrategy
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting file to jpg");
            Console.WriteLine("...");
            Console.WriteLine("Convert complete");
            Console.WriteLine();
        }
    }
}

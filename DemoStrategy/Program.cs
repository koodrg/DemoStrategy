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
            Context context = new Context();
            while (true)
            {
                Console.WriteLine("Choose file extension: 1.Gif \t 2.Png \t 3.Jpg");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    context = new Context(new GifStrategy());
                }
                else if(choose == "2")
                {
                    context = new Context(new PngStrategy());
                }
                else if(choose == "3")
                {
                    context = new Context(new JpgStrategy());
                }
                else
                {
                    break;
                }
                context.DoAlgorithm();
            }
            Console.ReadKey();
        }
    }
}

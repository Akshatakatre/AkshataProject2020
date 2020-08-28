using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @short
{
    class Program
    {
        static void Main(string[] args)
        {
            short n, sqr;
            Console.WriteLine("enter the number");
            n = Convert.ToInt16(Console.ReadLine());
            sqr = Convert.ToInt16(n * n);
            Console.WriteLine("square:" + sqr);
            Console.ReadKey();
        }
    }
}

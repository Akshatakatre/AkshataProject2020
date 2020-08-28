using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @long
{
    class Program
    {
        static void Main(string[] args)
        {
            long n,sqr;
            Console.WriteLine("enter the number");
            n = Convert.ToInt64(Console.ReadLine());
            sqr = Convert.ToInt64(n * n);
            Console.WriteLine("square:" + sqr);
            Console.ReadKey();

        }
    }
}

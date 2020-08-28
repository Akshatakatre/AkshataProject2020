using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sqr;
            Console.WriteLine("enter the number");
           
            n = Convert.ToInt32(Console.ReadLine());
            sqr = n * n;
            Console.WriteLine("square: " + sqr);
            Console.ReadKey();
        }
    }
}

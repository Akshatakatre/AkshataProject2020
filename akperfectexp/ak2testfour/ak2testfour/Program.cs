using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak2testfour
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,n;
            Console.WriteLine("enter two number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number which is multiple");
            n = Convert.ToInt32(Console.ReadLine());
            if(a%n==0)
            {
                Console.WriteLine("number is multiple");
            }
            else if (b % n == 0)
            {
                Console.WriteLine("number is multiple");
            }
            else
            {
                Console.WriteLine("number is not multiple");
            }
            Console.ReadKey();
        }
    }
}

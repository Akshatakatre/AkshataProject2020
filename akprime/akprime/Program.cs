using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akprime
{
    class Program
    {
        static void prime()
        {
            int num,i=2;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (num % i == 0)
                    Console.WriteLine("not prime number ");
               // break;
                i++;

            } while (i <= num - 1);
            if (num == i)
                Console.WriteLine("no is prime");
        }
        static void Main(string[] args)
        {
            prime();
            Console.ReadKey();
        }
    }
}

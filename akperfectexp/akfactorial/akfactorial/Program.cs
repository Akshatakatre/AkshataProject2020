using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akfactorial
{
    class factpro
    {
        static void Main(string[] args)
        {
            int n,fact = 1;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                fact = fact * n;
                n--;
            } while (n != 0);
            Console.WriteLine("factorial is" + fact);
            Console.ReadKey();

        }
    }
}

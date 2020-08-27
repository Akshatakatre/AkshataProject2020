using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akperfectexp
{
    class Program
    {
        static void perfect()
        {
            int n, a, f = 0;
            for(a=1;a< n;a++)
            {
                if (n % a == 0)
                    f = f + a;
            }
            if (n == f)
                Console.WriteLine("number is perfect");
            else
                Console.WriteLine("no is not perfect");
        }
        
           
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            perfect();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akpalendrom
{
    class Program
    {
        static int pale(ref int n)
        {
            int num, n1, n2, n3, rev;
            
            num = n;
            n1 = num % 10;
            num = num / 10;
            n2 = num % 10;
            num = num / 10;
            n3 = num % 10;
            num = num / 10;
            rev = n1 * 100 + n2 * 10 + n3 * 1;
            Console.WriteLine("reverse:" + rev);
            if (rev==num)
                Console.WriteLine("no is palendrom");
            else
                Console.WriteLine("no is not palendrom");
            return rev;
        }
        static void Main(string[] args)
        {
            int n,x;

            Console.WriteLine("enter 3 digit number");
            n = Convert.ToInt32(Console.ReadLine());
            x=pale(ref n);
            Console.ReadKey();
        }
    }
}

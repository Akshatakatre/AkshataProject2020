using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akarmstrong
{
    class Program
    {
        static void arm(int n)
        {
            int num, n1, n2, n3, result;
            num = n;
            n1 = n % 10;
            n = n / 10;
            n2 = n % 10;
            n = n / 10;
            n3 = n % 10;
            n= n / 10;
            result = n1 * n1 * n1 + n2 * n2 * n2 + n3 * n3 * n3;
            Console.WriteLine("result:" + result);
            if (num==result)
            {
                Console.WriteLine("armstrong number");
            }
            else
            {
                Console.WriteLine("not armstrong number");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter 3 digit number");
            n= Convert.ToInt32(Console.ReadLine());
            arm(n);
            Console.ReadKey();
        }
    }
}

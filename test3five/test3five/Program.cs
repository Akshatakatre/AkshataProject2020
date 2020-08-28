using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3five
{
    class Program
    {
        public void calculate()
        {
            int n1, n2, r = 0;
            Console.WriteLine("enter two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
           for(int i=n1;i<= n2;i++)
            {
                if (n1 % 17 != 0)
                {
                    r = r + n1;
                    Console.WriteLine("sum of the number is:" + r);
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.calculate();
            Console.ReadKey();
        }
    }
}

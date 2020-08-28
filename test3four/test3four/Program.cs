using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3four
{
    class Program
    { 
        public void divide()
        {
            int r;
            Console.WriteLine("enter two numbers");
           int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if(n1>n2)
            {
                r = n1 / n2;
                Console.WriteLine("result is :" + r);
                Console.WriteLine("division is possible");
            }
            else
            {
                Console.WriteLine("division not possible");
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.divide();
            Console.ReadKey();
        }
    }
}

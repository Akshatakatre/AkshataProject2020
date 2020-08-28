using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS6five
{
    class Sum
    {
        public int num { get; set; }
        public int sum,n1,n2,n3;
        public void calculate()
        {
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            if(num<500)
            {
                n1 = num % 10;
                num = num / 10;
                n2 = num % 10;
                num = num / 10;
                n3 = num % 10;
                num = num / 10;
                sum = n3 + n2 + n1;
                Console.WriteLine("the sum of the digit is: " + sum);
            }
            else
            {
                Console.WriteLine("greater than 500");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            s.calculate();
            Console.ReadKey();
        }
    }
}

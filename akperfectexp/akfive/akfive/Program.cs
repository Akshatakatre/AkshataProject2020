using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akfive
{
    class Program
    {
        static void calculate()
        {
            int[] num = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter the number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            foreach(int n in num)
            {
                total = total + n;
                
            }
            Console.WriteLine("total is:" + total);
        }
        static void Main(string[] args)
        {
            calculate();
            Console.ReadKey();
        }
    }
}

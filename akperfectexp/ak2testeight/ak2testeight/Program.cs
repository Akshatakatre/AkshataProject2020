using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak2testeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,avg,total=0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter 5 number");
                num = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                {
                    total = total + i;

                }
            }
            avg = total / 2;
            Console.WriteLine("total is:" + total);
            Console.WriteLine("average is :" + avg);
            Console.ReadKey();

        }
    }
}

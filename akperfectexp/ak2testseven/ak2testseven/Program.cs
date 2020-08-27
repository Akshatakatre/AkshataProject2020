using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak2testseven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,p=0,n=0;
            //num = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("enter five numbers");
                Console.ReadLine();

                if (i > 0)
                {
                    p++;
                    // Console.WriteLine("the number is positive:"+p);
                }
                if (i < 0)
                {
                    n++;
                    //Console.WriteLine("the number is negative:"+n);
                }
            }
            Console.WriteLine("the number is positive:" + p);
            Console.WriteLine("the number is negative:" + n);
            Console.ReadKey();
        }
    }
}

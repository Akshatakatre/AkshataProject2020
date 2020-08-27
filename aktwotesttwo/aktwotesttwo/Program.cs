using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktwotesttwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int k, so=0;
            Console.WriteLine("enter the 5 digit number");
            
           for(int i=0;i<5;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                k=num[i] % 2;
                if ( k != 0)

                    so = so + num[i];

            }
                Console.WriteLine("sum of the odd number is:" + so);
            
            
            Console.ReadKey();
        }
    }
}

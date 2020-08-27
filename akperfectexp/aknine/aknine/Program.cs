using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aknine
{
   public class Program
    {
      public  static int prime(int n)
        {
            int num,i;
            num = n;
            for( i=2;i<= num-1;i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("the number is not prime");
                    break;
                }
            }
                if(i==num)
                {
                    Console.WriteLine("the number is prime");
                }
                
            
            return n;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            int r = prime(n);
            Console.ReadKey();
        }
    }
}

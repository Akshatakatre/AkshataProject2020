using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primetest
{
        
    public class Program
    {
        public  string check(int a)
        {
            int n, i = 2;
            string str=null;
            //Console.WriteLine("enter the number");
            n = a;
           // n = Convert.ToInt32(Console.ReadLine());
            // i = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (n % i == 0)
                {
                    str="number is not prime";
                    break;
                }
                i++;

            } while (i <= n - 1);
            if (n == i)
            {
                str="the number is prime";
            }
            return str;
        }



        static void Main(string[] args)
        {
        Program p = new Program();
           Console.WriteLine("enter the number");
           // int a = Convert.ToInt32(Console.ReadLine());
            int a=int.Parse(Console.ReadLine());
            String s=p.check(a);
            //Console.WriteLine("result is:"+)
            Console.WriteLine("output is:" + s);
        Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akasp
{
    class Program
    {
        static int[]  inmsg(params int[] a)
        {
            int n,i,res;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            res = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<a.Length;i++)
            {
                res = res + a[i];
                Console.WriteLine("result is :" + res);
                return a;

            }
        }
        static int[] xxx(params int[] b)
        {
            int x, j, res;
            Console.WriteLine("enter the array element");
            x = Convert.ToInt32(Console.ReadLine());
            for (j= 0; j< b.Length; j++)
            {
                res = res + b[j];
                Console.WriteLine("result is :" + res);
                return b;

            }

        }
        static int result()
        {
            int p;
            p = Convert.ToInt32(Console.ReadLine());
            p = a[i] + b[j];
        }
        static void Main(string[] args)
        {
        }
    }
}

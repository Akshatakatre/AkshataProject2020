using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akparamlist
{
    class Program
    {
        static long add(params long[] name)
        {
            long result=0,i;
           // i = Convert.ToInt64(Console.ReadLine());
          //  result = Convert.ToInt64(Console.ReadLine());
            for(i=0; i<name.Length;i++)
            {
                result = result + name[ i];
                
            }
            Console.WriteLine("result:" + result);
            return result;
        }
        static void Main(string[] args)
        {
            long a,b,c,d,r;
            Console.WriteLine("enter the number");
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());
            c = Convert.ToInt64(Console.ReadLine());
            d = Convert.ToInt64(Console.ReadLine());
            r= add(2,3,4,5);
            Console.WriteLine("result is:" + r);
            Console.ReadKey();

        }
    }
}

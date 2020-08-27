using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akseven
{
   public class Program
    {
        static int cal(int x,int y)
        {
            int a, b,i;
           // i = Convert.ToInt32(Console.ReadLine());
            a = x;
            b = y;
            for(i=1;i<b;i++)
            {
                a = a * b;
               // Console.WriteLine("result is:" + a);
           }
            Console.WriteLine("result is:" + a);
            return a;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter two number");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            cal(x, y);
            Console.ReadKey();
        }
    }
}

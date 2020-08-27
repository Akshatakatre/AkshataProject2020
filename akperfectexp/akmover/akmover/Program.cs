using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akmover
{
    class Program
    {
        static int cal(int a,int b)
        {
            int c = a * b;
            return c;

        }
        static float cal(int a,float b)
        {
            float d;
            d= a + b;
            return d;
        }
        static int cal(int a,int b,int c,int d)
        {
            int n;
            n = a * b * c * d;
            return n;

        }
        static void Main(string[] args)
        {
            int x, y, z;
            float r;
            Console.WriteLine("enter the number");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt64(Console.ReadLine());
            int s=cal(x, y);
            float p=cal(z, r);
            int q=cal(23, 6, 4, 3);

            Console.WriteLine("result is:" + s);
            Console.WriteLine("result is:" + p);
            Console.WriteLine("result is :" + q);
            Console.ReadKey();

        }
    }
}

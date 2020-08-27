using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akthree
{
    class Program
    {
        static void sum(int x,int y)
        {
            int a, b, c;
            a = x;
            b = y;
            //c = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("result is:" + c);
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter two numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            sum(x, y);
            Console.ReadKey();
        }
    }
}

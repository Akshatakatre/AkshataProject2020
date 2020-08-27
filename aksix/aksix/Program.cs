using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aksix
{
    
    class Program
    {
        static void swap(int x, int y)
        {
            int a, b, temp;
            a = x;
            b = y;



            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("first number is:" + a);
            Console.WriteLine("second number is:" + b);


        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter two numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            swap(x, y);
            Console.ReadKey();

        }
    }
}

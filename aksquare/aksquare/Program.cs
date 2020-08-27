using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aksquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, squ;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            squ = n * n;
            Console.WriteLine("square is:" + squ);
            Console.ReadKey();

        }
    }
}

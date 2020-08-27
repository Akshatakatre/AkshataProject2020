using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktestone
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, n1,n2,res;
            Console.WriteLine("enter the two items weight");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the number of purchase");
            n1 = Convert.ToSingle(Console.ReadLine());
            n2 = Convert.ToSingle(Console.ReadLine());
            // res = Convert.ToSingle(Console.ReadLine());
            res = a + b / n1*n2;
            Console.WriteLine("result is:" + res);
            Console.ReadKey();
        }
    }
}

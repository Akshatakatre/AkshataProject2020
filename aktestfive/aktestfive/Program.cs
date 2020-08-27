using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktestfive
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2,x1,x2,distance;
            Console.WriteLine("enter the two points");
            n1 = Convert.ToSingle(Console.ReadLine());
            n2= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the two points");
            x1 = Convert.ToSingle(Console.ReadLine());
            x2 = Convert.ToSingle(Console.ReadLine());
            distance = (n2 - n1) * (n2- n1) + (x2 - x1) * (x2-x1);
            Console.WriteLine("distance of the two points are:" + distance);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktestfour
{
    class Program
    {
        static void Main(string[] args)
        {
            int td;
            float f,average;
            Console.WriteLine("enter the total distance");
            td = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount of fuel ");
            f = Convert.ToSingle(Console.ReadLine());
            average = td / f;
            Console.WriteLine("average of the bike is:" + average);
            Console.ReadKey();

        }
    }
}

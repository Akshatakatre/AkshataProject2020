using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak2testthree
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, z,p;
            Console.WriteLine("enter the three values");
            x = Convert.ToSingle(Console.ReadLine());
            y = Convert.ToSingle(Console.ReadLine());
            z = Convert.ToSingle(Console.ReadLine());
            if(x<(y+z) && y<(x+z) && z<(x+y))
            {
                Console.WriteLine("made a triangle");
            }
            else
            {
                Console.WriteLine("not able to made a triangle");
            }
            p = x + y + z;
            Console.WriteLine("parameter value is :" + p);
            Console.ReadKey();
        }
    }
}

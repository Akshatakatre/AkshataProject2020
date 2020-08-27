using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akforce
{
    class Program
    {
        static void force(int x,int y)
        {
            int m, a, force;
            m = x;
            a = y;
            force = m * a;
            Console.WriteLine("force is:" + force);
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter masss and acceleration");
            x = Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            force(x,y);
            
            Console.ReadKey();

        }
    }
}

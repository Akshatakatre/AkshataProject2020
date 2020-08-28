using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3eight
{
    class Program
    {
        public void calculate()
        {
            int n, s, c;
            int p;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            s = n * n;
            c = n * n * n;
            Console.WriteLine("enter the number for how many times the line are print");
               p=int.Parse(Console.ReadLine());
            for(int i=0;i< p;i++)
            {
                Console.WriteLine("number={0},suqare={1},cube={2}", n, s, c);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.calculate();
            Console.ReadKey();
        }
    }
}

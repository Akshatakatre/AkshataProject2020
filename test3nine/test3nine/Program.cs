using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3nine
{
    class Program
    {
        public void print()
        {
            int p, q;
            Console.WriteLine("enter two numbers");
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of lines to print");
            int r = int.Parse(Console.ReadLine());
            for(int i=0;i< r;i++)
            {
                Console.WriteLine("value of p is:" + p);
            }
        } 
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
            Console.ReadKey();
        }
    }
}

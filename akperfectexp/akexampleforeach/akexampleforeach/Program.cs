using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akexampleforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            char name;
            int[] n = new int[3];
            Console.WriteLine("enter the element size");
            Console.WriteLine("enter name");
            name = Convert.ToChar(Console.ReadLine());
            n[0] =6;
            n[1] = 2;
            n[2] = 4;

            foreach(int i in n)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

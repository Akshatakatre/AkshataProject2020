using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktestthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("enter the three numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            if(n1>n2 || n1>n3)
            {
                Console.WriteLine("n1 is greater");
           }
            else if(n2>n3)
            {
                Console.WriteLine("n2 is greater");
            }
            else
            {
                Console.WriteLine("n3 is greater");
            }
            Console.ReadKey();
        }
    }
}

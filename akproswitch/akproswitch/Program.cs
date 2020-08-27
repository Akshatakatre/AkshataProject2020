using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akproswitch
{
    class greswipro
    {
        static void Main(string[] args)
        {
            int n1, n2, n3,i;
            Console.WriteLine("enter three numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter any number  1 or2");
            i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                    if (n1 > n2 || n1 > n3)
                        Console.WriteLine("n1 is greater");
                     break;
                case 2:
                    if (n2 > n3)
                        Console.WriteLine("n2 is greater");
                    else
                        Console.WriteLine("n3 is greater");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
            Console.ReadKey();
        }
    }
}

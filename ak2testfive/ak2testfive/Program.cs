using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak2testfive
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("january");
                    break;
                case 2:
                    Console.WriteLine("feburary");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;
                case 4:
                    Console.WriteLine("april");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("june");
                    break;
                case 7:
                    Console.WriteLine("july");
                    break;
                case 8:
                    Console.WriteLine("august");
                    break;
                case 9:
                    Console.WriteLine("september");
                    break;
                case 10:
                    Console.WriteLine("octomber");
                    break;
                case 11:
                    Console.WriteLine("november");
                    break;
                case 12:
                    Console.WriteLine("december");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
            Console.ReadKey();
        }
    }
}

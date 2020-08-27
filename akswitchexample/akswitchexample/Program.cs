using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akswitchexample
{
    class sscol
    {
        static void Main(string[] args)
        {
            char color;
            Console.WriteLine("enter any character:");
            color = Convert.ToChar(Console.ReadLine());
            switch (color)
            {
               case 'R':
                    Console.WriteLine("Red");
                    break;
                case 'B':
                    Console.WriteLine("Blue");
                    Console.WriteLine("Black");
                    break;
                    
                case 'G':
                    Console.WriteLine("Green");
                    break;
                default:
                    Console.WriteLine("color not available");
                    break;

            }
            Console.ReadKey();
        }
    }
}

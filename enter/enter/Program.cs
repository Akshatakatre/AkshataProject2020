using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enter
{
    class Programenter
    {
        static void Main(string[] args)
        {
            Console.Write("\n press Enter  to exit the program ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("press enter");

            }
            Console.ReadKey();
        }
    }
}

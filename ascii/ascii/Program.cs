using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            int c = Console.Read();
            Console.WriteLine("ascii_value=" + c);
            Console.WriteLine("c=" + Convert.ToChar(c));
            Console.ReadKey();

        }
    }
}

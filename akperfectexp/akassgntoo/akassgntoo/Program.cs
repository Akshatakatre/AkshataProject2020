using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akassgntoo
{
    class Program
    {
        static void ptwo(string a)
       {
            string name;
            name = a;
            Console.WriteLine("Welcome Friend "   + name);
            Console.WriteLine("Have a nice day!");
        }
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("enter the name");
            a = Convert.ToString(Console.ReadLine());
            ptwo(a);
            Console.ReadKey();
        }
    }
}

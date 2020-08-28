using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @readonly
{
    class set
    {
        public readonly string name = "akshu";
    }
    class Program
    {
        static void Main(string[] args)
        {
            set s = new set();
            string st = s.name;
            Console.WriteLine("the name is :" + st);
            Console.ReadLine();

        }
    }
}

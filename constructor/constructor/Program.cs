using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Number
    {
        public int num;
        public Number()
        {
            num = 26;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Console.WriteLine("number is :" + n.num);
            Console.ReadKey();
        }
    }
}

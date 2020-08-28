using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS6two
{
    class Move
    {
        public int number { get; set; }
        public void shift()
        {
            Console.WriteLine("enter the number");
            number = int.Parse(Console.ReadLine());
            number <<= 2;
            Console.WriteLine("the result is:" + number);        

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Move m = new Move();
            m.shift();
            Console.ReadKey();
        }
    }
}

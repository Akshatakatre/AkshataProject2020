using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS6one
{
    class Check
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public void Swap()
        {

            Console.WriteLine("enter the number1");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number2");
            number2 = int.Parse(Console.ReadLine());
            int res = number1 + number2;
            res = res - number1;
            Console.WriteLine("first number swap is" + res);
            res = number1 + number2;
            res =  res- number2;
            Console.WriteLine("second number swap is" + res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Check c = new Check();
            c.Swap();
            Console.ReadKey();
        }
    }
}

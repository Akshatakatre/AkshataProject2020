using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS6three
{
   public class Reverse
    {
        public int number { get; set; }
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
        public int rev { get; set; }
        public void numRev()
        {
            Console.WriteLine("enter three digit number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("the number is:" + number);
            number1 = number % 10;
            number = number / 10;
            number2 = number % 10;
            number = number / 10;
            number3 = number % 10;
            number = number / 10;
            int res = number1 * 100 + number2 * 10 + number3 * 1;
            Console.WriteLine("the reverse of the number is:" + res);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Reverse r = new Reverse();
                r.numRev();
            Console.ReadKey();
        }
    }
}

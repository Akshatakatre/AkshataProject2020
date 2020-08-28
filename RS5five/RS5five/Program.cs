using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS5five
{
    class Tringular
    {
        public int number { get; set; }
        public int sum { get; set; }
        public void series(int num)
        {
            number = num;
            for(int Number=1;Number< number;Number++)
            {
                Console.WriteLine("the tringular series is:" + sum);
                sum = sum + Number;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tringular t = new Tringular();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            t.series(num);
            Console.ReadKey();
        }
    }
}

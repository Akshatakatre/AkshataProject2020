using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS5three
{
    class Square
    {
        public int number { get; set; }
        public int sum { get; set; }
        public void series(int num)
        {
            number = num;
            for(int Number=1;Number< number;Number++)
            {
                Console.WriteLine("square series is:" + sum);
                sum = Number * Number;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            s.series(num);
            Console.ReadKey();
        }
    }
}

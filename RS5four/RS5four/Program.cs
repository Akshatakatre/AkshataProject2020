using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS5four
{
    class Cube
    {
        public int number { get; set; }
        public int sum { get; set; }
        public void series(int num)
        {
            number = num;
            for(int Number=1;Number< number;Number++)
            {
                Console.WriteLine("the cube series is:" + sum);
                sum = Number * Number * Number;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube();
            Console.WriteLine("enter the number");
           int num=int.Parse( Console.ReadLine());
            c.series(num);
            Console.ReadKey();
        }
    }
}

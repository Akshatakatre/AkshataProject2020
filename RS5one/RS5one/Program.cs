using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS5one
{
    class Arithmetic
    {
        public int number { get; set; }
        public void series(int num)
        {
            number = num;
            for(int i=1;i< number;)
            {
                i= i + 3;
                Console.WriteLine("the arithmetic series is:" + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic a = new Arithmetic();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            a.series(num);
            Console.ReadKey();
        }
    }
}

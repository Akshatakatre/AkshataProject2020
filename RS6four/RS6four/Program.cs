using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS6four
{
    class Real
    {
        public int r1 { get; set; }
        public int r2 { get; set; }
        public int r3 { get; set; }
        public int r4 { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public void check()
        {
            Console.WriteLine("enter the first number");
            r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            r3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the fourth number");
            r4 = int.Parse(Console.ReadLine());
            if (r1 > r2 && r1 > r3 && r1 > r4)
            {
                Console.WriteLine("r1 is greater");
            }
            else if (r2 > r1 && r2 > r3 && r2 > r4)
            {
                Console.WriteLine("r2 is greater");
            }
            else if (r3 > r1 && r3 > r2 && r3 > r4)
            {
                Console.WriteLine("r3 is greater");
            }
            else if (r4 > r1 && r4 > r2 && r4 > r3)
            {
                Console.WriteLine("r4 is greater");
            }
        }
            public void Min()
        { 
             if (r1 < r2 && r1 < r3 && r1 < r4)
            {
                Console.WriteLine("r1 is min");
            }
            else if (r2 < r1 && r2 < r3 && r2 < r4)
            {
                Console.WriteLine("r2 is min");
            }
            else if (r3 < r1 && r3 < r2 && r3 < r4)
            {
                Console.WriteLine("r3 is min");
            }
            else if (r4 < r1 && r4 < r2 && r4 < r3)
            {
                Console.WriteLine("r4 is min");
            }
        }
        public void cal()
        {
            int res = max - min;
            Console.WriteLine("the difference is:" + res);
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Real r = new Real();
            r.check();
        r.Min();
        r.cal();
            Console.ReadKey();

        }
    }
}

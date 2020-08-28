using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS6six
{
    class Positive
    {
        public int num { get; set; }
        public int avg, max, min;
        public void average()
        {
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                if (num <= 0)
                {
                  
                    break;
                }
                Console.WriteLine("the number is:" + num);
                num = num % 10;
                num = num / 10;
                num++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Positive p = new Positive();
            p.average();
            Console.ReadKey();
        }
    }
}

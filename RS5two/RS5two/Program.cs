using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS5two
{
    class Geometric
    {
        public int number { get; set; }
      
        public void series(int num)
        {
            number = num;
            int i = 5;
            for ( i=5;i< number;)
            {
                Console.WriteLine("the geometric series is:" + i);
               
                i = i +i;
               
            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geometric g = new Geometric();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            g.series(num);
            Console.ReadKey();
        }
    }
}

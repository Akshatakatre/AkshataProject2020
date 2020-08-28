using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3six
{
    class Program
    {
        public void check()
        {
            int n1, n2;
            Console.WriteLine("enter two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            for(int i= n1;i<= n2;i++)
            {
                if(i%7==2 )
                {
                    
                    Console.WriteLine("the number is:" + i);
                }
                else if(i%7==3)
                {
                    Console.WriteLine("the number is:" + i);
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.check();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3seven
{
    class Program
    {
        public void print()
        {
            int p;
            string n1;
            Console.WriteLine("enter the three number");
           n1=Convert.ToString( Console.ReadLine());
           // n2 = int.Parse(Console.ReadLine());
           // n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number for how many lines are print");
            p = int.Parse(Console.ReadLine());
            for(int i=0;i< p;i++)
            {
                Console.WriteLine(n1);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
            Console.ReadKey();
        }
    }
}

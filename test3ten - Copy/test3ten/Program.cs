using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3ten
{
    class Program
    {
        public void marks()
        {
            int s, m, total = 0, p,q=1;
            float avg;
            
            Console.WriteLine("enter the number of students");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of maths");
            for (int i = 0; i < s; i++)
            {
                m = int.Parse(Console.ReadLine());
                total = total + m;
            }
            Console.WriteLine("total is" + total);
           
            Console.WriteLine("enter zero to calculate the average");
            p = int.Parse(Console.ReadLine());
            if (p == 0)
            { 

            avg = total / s;
            Console.WriteLine("average marks is:" + avg);
        }
            Console.WriteLine("enter any negative number for execute the code");
          //  q = int.Parse(Console.ReadLine());
            if(q<0)
            {
                q = int.Parse(Console.ReadLine());
                Console.WriteLine("terminate the process");
            }
        }
        static void Main(string[] args)
        {
            
            Program p = new Program();
            p.marks();
            Console.ReadKey();
        }
    }
}

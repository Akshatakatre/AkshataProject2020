using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3one
{
    class check
    {
        public int n1,n2;
        public void display(int a,int b)
        {
            n1 = a;
            n2 = b;
            if(n1<n2)
            {
                Console.WriteLine("the number is in ascending order");
            }
            else
            {
                Console.WriteLine("the number is in descending order");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter two number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            check c = new check();
            c.display(a,b);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akten
{
    public class Program
    {
        static int sum(int x)
        {
            int num,n1,n2,n3,n4,res;
            num = x;
            n1 = num % 10;
            num = num / 10;
            n2 = num % 10;
            num = num / 10;
            n3 = num % 10;
            num = num / 10;
            n4 = num % 10;
            num = num / 10;
            res = n1 + n2 + n3 + n4;
            Console.WriteLine("the sum of the number is:" + res);
            return res;
            
       }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter the 4 digit number");
            x = Convert.ToInt32(Console.ReadLine());
            int result = sum(x);
            Console.ReadKey();
        }
    }
}

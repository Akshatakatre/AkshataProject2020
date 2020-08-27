using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akfinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {
                int num, n1, n2, n3, rev;
                Console.WriteLine("enter the three digit number");
                num = Convert.ToInt32(Console.ReadLine());
                n1 = num % 10;
                num = num / 10;
                n2 = num % 10;
                num = num / 10;
                n3 = num % 10;
                num = num / 10;
                rev = n1 * 100 + n2 * 10 + n3 * 1;
                Console.WriteLine("reverse:" + rev); 
             }
        catch(OverflowException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("overall code is executed");
            }
            Console.ReadKey();
        }
    }
}

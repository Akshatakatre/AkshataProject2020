using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktrycatch
{
    class tcpro
    {
        static void Main(string[] args)
        {
            try
            { 
                int num1,num2, res;
                Console.WriteLine("enter two numbers");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
            
            
                res = num1 / num2;
                Console.WriteLine("result is:" + res);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("number is long");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("execute all code");
            Console.ReadKey();
        }
    }
}

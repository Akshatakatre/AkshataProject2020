using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak2testsix
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
           Console.WriteLine("the even number from 1 to 50");
            
        
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {

                    
                    Console.WriteLine("the even number is"+i);  
                }
            }
            Console.ReadKey();
        }
    }
}

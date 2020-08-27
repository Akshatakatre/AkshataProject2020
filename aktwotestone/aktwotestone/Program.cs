using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktwotestone
{

    class Program
    {   
        static void Main(string[] args)
        {
        Program p = new Program();
        Console.WriteLine("enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
            if ( num <= 10)
            {
                Console.WriteLine("range is 0 to 10");

            }
            else if ( num <= 20)
            {
                Console.WriteLine("range is 11 to 20");

            }

            else if ( num <= 30)
            {
                Console.WriteLine("range is 21 to 30");
            }
            else if ( num <= 40)
            {
                Console.WriteLine("range is 31 to 40");
            }
            else if ( num <= 50)
            {
                Console.WriteLine("range is 41 to 50");
            }
            else if ( num <= 60)
            {
                Console.WriteLine("range is 51 to 60");
            }
            else if ( num <= 70)
            {
                Console.WriteLine("range is 61 to 70");
            }
            else if ( num <= 80)
            {
                Console.WriteLine("range is 71 to 80");
            }
            else
            {
                Console.WriteLine("error the number is greater tham 80 or negative number");
            }
        
  Console.ReadKey();
        }
    }
}

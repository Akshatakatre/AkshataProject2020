using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akoutparameter
{
    class Program
    {
        static void outm(out int n)
        {
            
            
        //    Console.WriteLine("value of i is:" + i);
            
        }
        int i;
        int n;
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            outm(out n);
            
            Console.WriteLine("value of n:" + n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3two
{
   public  class pass
    {
        public  int i;  
        public  int p=1234;
        public  void check()
        {
            
            Console.WriteLine("enter the 4 digit password");
            i = Convert.ToInt32(Console.ReadLine());
            if (p==i)
            {
                Console.WriteLine("correct password");
            }
            else 
            {
                Console.WriteLine("incorrect password");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
       
          
            pass p = new pass();
           p. check();
            Console.ReadKey();
            
        }
    }
}

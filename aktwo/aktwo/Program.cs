using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktwo
{
    class Program
    {
        static string dis()
        {
            string str1;
            //Console.WriteLine("enter the name");
           // string name = Convert.ToString(Console.ReadLine());
            str1 = "Welcome Friend Jhon \n Have a nice day";
                
            
            return str1 ;
        }
        static void Main(string[] args)
        {
           string str= dis();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akfour
{
   public class Program
    {
        static void count(string s)
        {
            int sp=1;
            int i;
           // i = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("This is a test string");
            for(i=0;i<s.Length;i++)
            {
                if(s[i]==' ')
                {
                   // Console.WriteLine("space=" + i);
                    sp++;
                }
            }
            Console.WriteLine("space is:" + sp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter any sentence");
            string str = Console.ReadLine();
            count(str);
            Console.ReadKey();
        }
    }
}

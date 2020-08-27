using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akptr
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i>=4;i++)
            {
                for(j= 4;j<0;j--)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
        
    }
}

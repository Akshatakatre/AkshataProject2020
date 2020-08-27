using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akptrnpro
{
    class Program
    {
        static void pattern()
        {
            int i, j;
            for(i=1;i<=3;i++)
            {
                for(j=1;j<= i;j++)
                {
                    Console.WriteLine(j);

                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            pattern();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akpatternexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i <= 3; i++)
            {
                for(j=3;j>0;j--)
                {
                    Console.Write("*",+j);

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}

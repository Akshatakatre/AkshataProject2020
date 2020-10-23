using System;

namespace IfElseStatement4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 2; i >= 0; i--)
            {
                for (j = 0; j <= 2; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                Console.WriteLine("\n");
                Console.ReadKey();

            }
        }
    }
}

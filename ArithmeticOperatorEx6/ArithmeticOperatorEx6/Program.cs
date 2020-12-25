using System;

namespace ArithmeticOperatorEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int x = 4;
            int z, c, k;
            for (c = 1; c <= n; c++)
            {
                for (k = 1; k <= c; k++)
                {
                    z = 3 * x * x + 2 * x + 4 / x + 8;
                    Console.Write(Convert.ToString(Convert.ToChar(z)));
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace WhileLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 3; i++)
            {
                j = 1;
                while (i % j == 2)
                {
                    j++;
                }
                Console.WriteLine(i + " " + j);
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace WhileLoop9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            while (++i <= 10)
            {
                j++;
            }
            Console.WriteLine(i + "  " + j);
            Console.ReadLine();

        }
    }
}

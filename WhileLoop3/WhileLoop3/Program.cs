using System;

namespace WhileLoop3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;
            while (i++ < 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            i = 0;
            while (++i < 5)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}

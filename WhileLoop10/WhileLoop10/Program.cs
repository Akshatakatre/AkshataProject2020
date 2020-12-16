using System;

namespace WhileLoop10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 1)
            {
                if ('A' < 'a')
                {
                    Console.WriteLine("Hello...");
                }
                else
                {
                    Console.WriteLine("Hi...");
                }
                i++;
            }
            Console.ReadLine();

        }
    }
}

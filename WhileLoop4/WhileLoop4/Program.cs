using System;

namespace WhileLoop4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 20)
            {
                while (x < 10)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine(x);
                    }
                    x++;
                }
            }
            Console.ReadLine();

        }
    }
}

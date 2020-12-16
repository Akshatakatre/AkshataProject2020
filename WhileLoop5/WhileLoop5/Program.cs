using System;

namespace WhileLoop5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            while (c <= x)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine("Execute While " + c + "\t" + "time");
                }
                c++;
            }
            Console.ReadLine();

        }
    }
}

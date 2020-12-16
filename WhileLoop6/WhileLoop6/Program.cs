using System;

namespace WhileLoop6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                n = n / 10;
                Console.WriteLine(+r);
            }
            Console.ReadLine();

        }
    }
}

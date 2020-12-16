using System;

namespace doWhileExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            long x;
            x = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(x % 10);
            } while ((x = x / 10) != 0);
            Console.ReadLine();

        }
    }
}

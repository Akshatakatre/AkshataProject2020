using System;

namespace doWhileExample10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 1; x <= 3; x++)
            {
                int j = 1;
                do
                {
                    j++;
                } while (x % j == 2);
                Console.WriteLine(x + " " + j);
            }
            Console.ReadLine();

        }
    }
}

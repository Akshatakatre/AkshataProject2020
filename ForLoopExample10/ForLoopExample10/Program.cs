using System;

namespace ForLoopExample10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1, j = i; i <= 3 && j >= 0; i++, j--)
            {
                if (i == j)
                    continue;
                else
                    Console.WriteLine(j);
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace ArithmeticOperatorEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 1, k;
            for (i = 0; i < 3; i++)
            {
                k = j++ - ++j;
                Console.Write(k + " ");
            }
            Console.ReadKey();
        }
    }
}

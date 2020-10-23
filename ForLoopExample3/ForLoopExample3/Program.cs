using System;

namespace ForLoopExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, X;
            for (I = 1; I <= (9 % 2 + I); I++)
            {
                X = (I * 3 + I * 2) / I;
                Console.WriteLine(X);
            }
            Console.ReadKey();

        }
    }
}

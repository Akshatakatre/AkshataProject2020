using System;

namespace ArithmeticOperatorEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x;
            a = 80;
            b = 15;
            c = 2;
            x = a - b / (3 * c) * (a + c);
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}

using System;

namespace ArithmeticOperatorEx8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 10;
            int d = 12;
            int e = 5;
            int f = 6;
            a = c * (d + e) / f + d;
            Console.WriteLine(a);
            b = c * (d + e / f + d);
            Console.WriteLine(b);
            if (a < b)
            {
                Console.WriteLine(" parentheses changes values");
            }
            else if (a > b)
            {
                Counterintelligence("they have same value");
            }
            Console.ReadLine();

        }

        private static void Counterintelligence(string v)
        {
            throw new NotImplementedException();
        }
    }
}

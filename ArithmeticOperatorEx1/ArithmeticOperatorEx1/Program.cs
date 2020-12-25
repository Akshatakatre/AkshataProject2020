using System;

namespace ArithmeticOperatorEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 16.4f;
            int b = 12;
            float c;
            c = a * (b + a) / (a - b);
            Console.WriteLine("result is :" + c);
            Console.ReadLine();

        }
    }
}

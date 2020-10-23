using System;

namespace ForLoopExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J = 0;
            for (I = 1; I < 10;) ;
            {
                J = J + I;
                I += 2;
            }
            Console.WriteLine("Sum of first 10 even numbers is:" + J);
            Console.ReadKey();

        }
    }
}

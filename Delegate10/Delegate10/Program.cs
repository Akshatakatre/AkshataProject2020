using System;

namespace Delegate10
{
    delegate int Arithm(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            DoOperation(10, 4, Multiply);
            DoOperation(10, 2, Divide);
            Console.ReadKey();
        }

        static void DoOperation(int x, int y, Arithm del)
        {
            int z = del(x, y);
            Console.WriteLine(z);
        }

        static int Multiply(int x, int y)
        {
            Console.WriteLine("Multiplycation is : ", x * y);
            return x * y;
        }

        static int Divide(int x, int y)
        {
            Console.WriteLine("division is : ", x / y);
            return x / y;
        }
    }
    
}

using System;

namespace Delegate9
{
    delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = delegate
            {
                Console.WriteLine("Anonymous method");
            };

            del();
            Console.ReadKey();
        }
    }
}

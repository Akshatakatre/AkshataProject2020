using System;

namespace SwitchExample3
{
    class Program
    {
        static void Main(string[] args)
        {

            int const p = 0;
            switch (3 * 5 / 6)
            {
                case p:
                    Console.WriteLine("A");
                    break;
                case p * 1:
                    Console.WriteLine("B");
                    break;
                case p - 2:
                    Console.WriteLine("C");
                    break;
                default:
                    Console.WriteLine("D");
            }
            //error occur in this code
        }
    }
}

using System;

namespace WhileLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            float s = 0.1f;
            while (s <= 0.5f)
            {
                ++s;
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}

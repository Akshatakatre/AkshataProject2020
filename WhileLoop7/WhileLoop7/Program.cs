using System;

namespace WhileLoop7
{
    class Program
    {
        static void Main(string[] args)
        {

            float i = 1.0f, j = 0.05f;
            while (i < 2.0f && j <= 2.0f)
            {
                Console.WriteLine(i++ - ++j);
            }
            Console.ReadLine();

        }
    }
}

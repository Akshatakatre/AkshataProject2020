using System;

namespace doWhileExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = 1.0f, j = 0.05f;
            do
            {
                Console.WriteLine(i++ - ++j);
            } while (i < 2.0f && j <= 2.0f);
            Console.ReadKey();

        }
    }
}

using System;

namespace ForLoopExample2
{
    class Program
    {
        static void Main(string[] args)
        {

            float f;
            for (f = 0.1f; f <= 0.5; f += 1)
                Console.WriteLine(++f);
            Console.ReadKey();

        }
    }
}

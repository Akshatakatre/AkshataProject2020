using System;

namespace ForLoopExample6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s = 0;
            for (i = 1; i <= 10; s = s + i, i++) ;
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }
    }
}

using System;

namespace doWhileExampe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 5;
            do
            {
                Console.WriteLine(i = i++ * j);
            } while (i <= 10);
            Console.ReadLine();

        }
    }
}

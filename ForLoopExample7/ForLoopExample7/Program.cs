using System;

namespace ForLoopExample7
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.WriteLine("Hi");
            for (i = 1; i <= 10; i++)
                Program.Main(args);
            Console.ReadKey();

        }
    }
}

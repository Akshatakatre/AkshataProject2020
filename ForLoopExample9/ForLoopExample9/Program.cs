using System;

namespace ForLoopExample9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = -3; i <= 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                }
                if (i > 0)
                    Console.WriteLine("A");
                else if (i < 0)
                    Console.WriteLine("B");
            }
            Console.ReadLine();

        }
    }
}

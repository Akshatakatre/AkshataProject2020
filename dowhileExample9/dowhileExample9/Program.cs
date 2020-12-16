using System;

namespace dowhileExample9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                x++;
                if (x == 5)
                {
                    x++;
                    continue;
                    break;
                }
                Console.WriteLine(x + " ");

            } while (x < 10);

        }
    }
}


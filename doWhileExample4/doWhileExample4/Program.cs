using System;

namespace doWhileExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1234, j = 0;
            /*ADD CODE HERE */
            do
            {
                j = j + (i % 10);
            } while ((i = i / 10) != 0);

            Console.WriteLine(j);

        }
    }
}

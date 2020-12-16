using System;

namespace WhileLoop8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 50)
            {
                if (i % 10 == 0)
                    continue;
                else
                    break;
                i += 10;
                Console.WriteLine(i % 10);
            }
          //run infinite loop but doesnt print any thing.

        }
    }
}

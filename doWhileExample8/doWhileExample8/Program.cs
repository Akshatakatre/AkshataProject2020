using System;

namespace doWhileExample8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 10; x <= 15; x++)
                while (Convert.ToBoolean(Convert.ToInt32(x)))
                {
                    do
                    {
                        Console.WriteLine(1);
                        if (Convert.ToBoolean(x >> 1))
                            continue;
                    } while (Convert.ToBoolean(0));
                    break;
                }
            Console.ReadLine();

        }
    }
}

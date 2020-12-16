using System;

namespace doWhileExample7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            do
            {
                Console.WriteLine(x++);
            }
            while (Convert.ToBoolean(5) && Convert.ToBoolean(4) && Convert.ToBoolean(3)
            && Convert.ToBoolean(2) && Convert.ToBoolean(1) && Convert.ToBoolean(0));
            Console.ReadLine();

        }
    }
}

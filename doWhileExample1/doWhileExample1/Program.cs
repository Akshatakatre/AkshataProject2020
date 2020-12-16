using System;

namespace doWhileExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 2, k = 3;
            do
            {
                Console.WriteLine((Convert.ToBoolean(Convert.ToInt32(i++)))
                && (Convert.ToBoolean(Convert.ToInt32(++j))));
            } while (i <= 3);
            Console.ReadKey();

        }
    }
}

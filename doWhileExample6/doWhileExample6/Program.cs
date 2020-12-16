using System;

namespace doWhileExample6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s = 0, a = 1, d;
            i = Convert.ToInt32(Console.ReadLine());
            do
            {
                d = i % (2 * 4);
                s = s + d * a;
            } while ((Convert.ToInt32(i = i / (2 * 4))) != 0
             && (Convert.ToBoolean(Convert.ToInt32((a) = (a * 10)))));
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}

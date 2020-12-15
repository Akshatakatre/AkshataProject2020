using System;

namespace SwitchExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, k = 3;
            switch (i - k)
            {
                case -1:
                    ++i;
                    ++k;
                    break;
                case 2:
                    --i;
                    ++k;
                    break;
                default:
                    i += 3;
                    k += i;
                    break;
            }
            Console.WriteLine(i + "\n" + k);
            Console.ReadKey();

        }
    }
}

using System;

namespace SwitchExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, j = 3, k = 4;
            switch (i + j - k)
            {
                case 0:
                case 2:
                case 4:
                    ++i;
                    k += j;
                    break;
                case 1:
                case 3:
                case 5:
                    --i;
                    k -= j;
                    break;
                default:
                    i += j;
                    break;
            }
            Console.WriteLine(i + "\n" + j + "\n" + k);
            Console.ReadKey();

        }
    }
}

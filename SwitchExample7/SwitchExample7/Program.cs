using System;

namespace SwitchExample7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j = 1;
            int[] ar = { 21, 22, 13, 4 };
            switch (ar[j])
            {
                case 1:
                    i++;
                    break;
                case 2:
                    i += 2;
                    j = 3;
                    continue;
                case 3:
                    i %= 2;
                    j = 4;
                    continue;
                default:
                    --i;
            }
            Console.WriteLine(i);
            Console.ReadKey();
            //error occur
        }
    }
}

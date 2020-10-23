using System;

namespace IfElseStatement5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 50, 65, 56, 88, 43, 52 };
            int even = 0, odd = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    odd += 1;
                }

            }
            Console.WriteLine("Even Numbers:" + even);
            Console.WriteLine("Odd Numbers:" + odd);
            Console.ReadLine();

        }
    }
}

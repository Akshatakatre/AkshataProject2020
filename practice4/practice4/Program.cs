using System;
using System.Linq;

namespace practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 4, 1, 3, 8, 6, 7, 2, 1 };

            var nums = numbers.Take(3);

            foreach (var n in nums)
            {

                Console.WriteLine(n);

            }


        }
    }
}

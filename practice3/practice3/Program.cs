using System;
using System.Linq;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 11, 3, 9, 8, 6, 7, 2, 0 };

            var nums = numbers.Skip(4);

            foreach (var n in nums)
            {
                Console.Write(n +"  ");
            }

        }
    }
}

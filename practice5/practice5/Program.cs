using System;
using System.Linq;

namespace practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 10, 0, 11 };

            var nums =
            from n in numbers
            select n + 1;

            foreach (var i in nums)
            {
                Console.Write(i +",");
            }

        }
    }
}

using System;
using System.Collections;
using System.Linq;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 };

            IEnumerable nums = A.Except(B);

            foreach (var n in nums)
            {
                Console.Write(n +"  ");
            }

        }
    }
}

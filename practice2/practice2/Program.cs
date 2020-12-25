using System;
using System.Linq;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 5, 6, 8 };
            int[] B = { 1, 3, 5, 7, 8 };

            var nums = A.Union(B);

            foreach (var n in nums)
            {
                Console.Write(n +"  ");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
namespace Delegate13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vals = new List<int> { 4, 2, 3, 0, 6, 7, 1, 9 };

            Predicate<int> myPred = greaterThanThree;

            List<int> vals2 = vals.FindAll(myPred);

            foreach (int i in vals2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static bool greaterThanThree(int x)
        {
            return x > 3;
        }
    }
    
}

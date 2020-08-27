using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akforeachloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new  int[3];
            num[0] = 2;
            num[1] = 6;
            num[2] = 4;
            foreach(int i in num)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}

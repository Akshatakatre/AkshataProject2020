using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktestsix
{
    class Program
    {
        static void Main(string[] args)
        {
            int amt,total=0;
            Console.WriteLine("enter the amount ");
            amt = Convert.ToInt32(Console.ReadLine());
           // total = Convert.ToInt32(Console.ReadLine());
            amt = amt - (total * 100);
            total = amt / 50;
            Console.WriteLine("note of 100:" + total);
            amt = amt - (total * 50);
            total = amt / 20;
            Console.WriteLine("note of 50:" + total);
            amt = amt - (total * 20);
            total = amt / 10;
            Console.WriteLine("note of 20:" + total);
            amt = amt - (total * 10);
            total = amt / 5;
            Console.WriteLine("note of 10:" + total);
            amt = amt - (total * 5);
            total = amt / 2;
            Console.WriteLine("note of 5:" + total);
            amt = amt - (total * 2);
            total = amt / 1;
            Console.WriteLine("note of 2:" + total);
            Console.WriteLine("notes of 1 :" + total);
            Console.ReadKey();

        }
    }
}

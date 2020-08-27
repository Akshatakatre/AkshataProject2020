using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akpercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            float per;
            Console.WriteLine("enter 3 numers");

            n1 = Convert.ToInt32(Console.ReadLine());
            n2= Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
      //  per = Convert.ToSingle(Console.ReadLine());

            per = (n1 + n2 + n3/ 300.00f)*100.00f;
           // Console.WriteLine("persentage:" + per);
            if ( per <= 75)
                Console.WriteLine("distenction");
            else if ( per <= 60)
                Console.WriteLine("1st division");
            else if (per < 50)
                Console.WriteLine("2nd division");
            else
                Console.WriteLine("fail");
            Console.ReadKey();

        }
    }
}

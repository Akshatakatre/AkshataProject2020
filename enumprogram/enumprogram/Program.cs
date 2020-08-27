using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumprogram
{
    class Program
    {
        enum grade { dist=75,first=60,second=50};
        static void Main(string[] args)
        {
            
        grade g = grade.dist;
        int g1 = Convert.ToInt32(g);
        Console.WriteLine("grade :"+g1);
            if(g1>=75)
            {
            Console.WriteLine("very good");
            }
    Console.ReadKey();
        }
    }
}

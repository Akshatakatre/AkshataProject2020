using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akforstatement
{
    class statefor
    {
        static void Main(string[] args)
        {
            char name;
            int i;
            Console.WriteLine("enter the name");

            name = Convert.ToChar(Console.ReadLine());
            for(i=0;i<=2;i++)
            {
                Console.WriteLine(+name);
            }
            for(i=0;i<=2;i++)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();


        }
    }
}

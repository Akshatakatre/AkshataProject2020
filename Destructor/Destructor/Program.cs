using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class car
    {
        public car()
        {
            Console.WriteLine("constructor is created");
        }
        ~car()
        {
            Console.WriteLine("destructor is called");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            Console.ReadKey();
        }
    }
}

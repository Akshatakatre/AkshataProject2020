using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktesttwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            float wh,sph,ms;
            Console.WriteLine("enter the employee id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter working hours of the employee");
            wh = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the per hour salary of the employee");
            sph = Convert.ToSingle(Console.ReadLine());
            ms = (wh * 30) * sph;
            Console.WriteLine("monthly salary is:" + ms);
            Console.ReadKey();

        }
    }
}

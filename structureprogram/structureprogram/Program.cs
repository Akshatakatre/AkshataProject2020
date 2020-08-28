using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structureprogram
{
    public struct Employee
    {
        public string fname;
        public int age;

    }
    class strupro
    {
        static void Main(string[] args)
        {
            Employee e;
            Console.WriteLine("enter name and age");
            e.fname = Console.ReadLine();
            e.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first name is:" + e.fname);
            Console.WriteLine("age is:" + e.age);
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Constructor3
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("This is our Default Constructor");
            Console.WriteLine("-----------------------------------------");
        }
        public Program(string name)
        {
            Console.WriteLine("This is our Parametrized Constructor");
            Console.WriteLine("Name is :" + name);
        }
        public Program(string name, int age)
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            Program s1 = new Program("Akshata");
            Program s2 = new Program("Akshu",24);
            Console.ReadKey();
        }
    }
}

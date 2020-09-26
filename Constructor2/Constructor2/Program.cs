using System;

namespace Constructor2
{
    class Program
    {
        static Program()
        {

            Console.WriteLine("Static Constructor");
        }
 
        public Program(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        public string detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }
        static void Main(string[] args)
        {
            Program obj = new Program(1);

            Console.WriteLine(obj.detail("Tom", 1));

            Program obj1 = new Program(2);

            Console.WriteLine(obj1.detail("Jerry", 2));
            Console.ReadKey();
        }
    }
}

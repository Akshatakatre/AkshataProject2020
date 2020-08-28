using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("this is parent class");
        }
    }
    class Child:Parent
    {
        public void display()
        {
            Console.WriteLine("this is child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            p.show();
            c.display();
            c.show();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class person
    {
        public string Pname;
        public int age;
        public void getData(string name,int a)
        {
            Pname = name;
            age = a;
        }
        public void show()
        {
            Console.WriteLine("this is person class");
            Console.WriteLine("person name is :" + Pname);
            Console.WriteLine("person age is:" + age);
        }
    }
    class person1:person
    {
        public  new void getData(string name, int a)
        {
            Pname = name;
            age = a;
        }
        public new void show()
        {
            Console.WriteLine("this is person 1 class");
            Console.WriteLine("person name is :" + Pname);
            Console.WriteLine("person age is:" + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            Console.WriteLine("enter the name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the age");
            int a = int.Parse(Console.ReadLine());
            p.getData(name,a);
            p.show();
            person1 p1 = new person1();
            Console.WriteLine("enter the name");
            string name1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the age");
            int a1 = int.Parse(Console.ReadLine());
            p1.getData(name1, a1);
            p1.show();
            Console.ReadKey();
        }
    }
}

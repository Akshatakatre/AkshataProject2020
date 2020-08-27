using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorexample
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(Person p)
        {
            name = p.name;
            age = p.age;
        }
        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public string Details()
        {
            return name +  " is "  + age.ToString();
        }

    }
    class Perexample
    {
       
        static void Main(string[] args)
        {
            Person p = new Person("akshata",23);
            Person p1 = new Person(p);
            p.age = 24;
            p1.age = 30;
            p1.name = "akshu";
            Console.WriteLine(p.Details());
            Console.WriteLine(p1.Details());
            Console.ReadKey();
        }
    }
}

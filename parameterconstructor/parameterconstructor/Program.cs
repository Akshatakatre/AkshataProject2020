using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterconstructor
{
    public class Person
    {
        private string first;
        private string last;
        public Person(string fname,string lname)
        {
            first = fname;
            last = lname;
        }
        public void show()
        {
            Console.WriteLine("first name is:" + first);
            Console.WriteLine("last name is:" + last);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("akshu", "katre");
            p.show();
            Console.ReadKey();
        }
    }
}

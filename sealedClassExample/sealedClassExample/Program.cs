using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedClassExample
{
    class Student
    {
        public string name;
        public void get(string n)
        {
            name = n;
            Console.WriteLine("the student class name is:" + name);
        }
    }
    sealed class Sdata:Student
    {
        public int rollno;
        public void set(int r)
        {
            rollno = r;
            Console.WriteLine("the sealed class roll no is :" + rollno);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("enter the name");
            string n = Console.ReadLine();
            Console.WriteLine("enter the roll no");
            int r = int.Parse(Console.ReadLine());
            Sdata sd = new Sdata();
            s.get(n);
            sd.set(r);
            sd.get(n);
            Console.ReadKey();
        }
    }
}

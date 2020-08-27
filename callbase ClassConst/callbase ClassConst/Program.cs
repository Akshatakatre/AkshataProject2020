using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbase_ClassConst
{
    class Student
    {
        public Student(string name)
        {
            name = "Akshu";
            Console.WriteLine("the name of the student is:" + name);
        }
    }
    class Sdata:Student
    {
        public Sdata(string name):base (name)
        {
            Console.WriteLine(" the derive class name=" + name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sdata s = new Sdata("rd");
            Console.ReadKey();
        }
    }
}

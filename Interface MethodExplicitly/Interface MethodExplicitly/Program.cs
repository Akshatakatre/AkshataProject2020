using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_MethodExplicitly
{
    interface Student
    {
        void get(string name);
    }
    abstract class Stu
    {
        public abstract void  set();
        public void show()
        {
            Console.WriteLine("non abstract method");
        }
        public void get(string name)
        {
            Console.WriteLine("good");
        }

    }
    class studentdata:Stu,Student
    {
        public int num = 26;
        public override void set()
        {
            Console.WriteLine("welcome in student data class");
        }
       public  new void get(string name)
        {
            name = "akshu";
            Console.WriteLine("the name is:" + name);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new studentdata();
            s.get("ak");
           Stu s1 = new studentdata();
            s1.set();
            s1.show();
            s1.get("rd");
            Console.ReadKey();
        }
    }
}

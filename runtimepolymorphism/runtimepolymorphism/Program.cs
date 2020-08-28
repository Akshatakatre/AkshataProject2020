using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtimepolymorphism
{
     abstract class student
    {
        public string Sname { get; set; }
        public int Rollno { get; set; }
       public int collegeCode { get; set; }
    public student()
        {
             collegeCode = 26;
        }

        public abstract void getData(string name, int rollno);
    //{
        //Sname = name;
       // Rollno = rollno;
    //}

    public virtual void show()
    {
        Console.WriteLine("base class");
        Console.WriteLine("student name is:" + Sname);
        Console.WriteLine("student roll no is :" + Rollno);
            Console.WriteLine("college code is:" + collegeCode);
        }
}
    class Sdata : student
    {
        public override void getData(string name, int rollno)
        {
            Sname = name;
            Rollno = rollno;
        }
        public override void show()
        {
            Console.WriteLine("derived class");
            Console.WriteLine("student name is:" + Sname);
            Console.WriteLine("student roll no is :" + Rollno);
            Console.WriteLine("college code is:" + collegeCode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new Sdata();
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter roll no");
            int r = int.Parse(Console.ReadLine());
            Sdata d = new Sdata();
            s.getData(name, r);
            s.show();
            d.getData(name, r);
            d.show();
            Console.ReadKey();
        }
    }

}


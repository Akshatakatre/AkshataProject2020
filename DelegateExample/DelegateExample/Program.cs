using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
   public class Student
    {
        public string name { get; set; }
        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public int total { get; set; }
        public void set()
        { 
            total = marks1 + marks2;
        }
        public void show()
        {
            Console.WriteLine("the student name is:" + name);
            Console.WriteLine("mark1 is:" + marks1);
            Console.WriteLine("mark2 is:" + marks2);
            Console.WriteLine("total marks is:" + total);

        }

    }
   public class Program
    {
        public delegate void studentData();
        public delegate void Studata();
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            string n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter mark 1");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark 2");
            int m2 = int.Parse(Console.ReadLine());
            Student s = new Student();
            //s.set(n, m1, m2);
            studentData sd= new studentData(s.set);
          //  sd(n, m1, m2); 
            Studata st = new Studata(s.show);
           
            //sd=new studentData(s.set);
            //st = new Studata(s.show);
            Console.ReadKey();
        }
    }

}

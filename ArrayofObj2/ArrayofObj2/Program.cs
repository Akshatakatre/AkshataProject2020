using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofObj2
{
    class Student
    {
        public int Rollno { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int average { get; set; }
       
        public void show()
        {
            average = (sub1 + sub2 + sub3) / 3;
            Console.WriteLine("the roll no" + Rollno);
            Console.WriteLine("the marks of subject 1: " + sub1);
            Console.WriteLine("the marks of subject 2: " + sub2);
            Console.WriteLine("the marks of subject 3:  " + sub3);
            Console.WriteLine(" the average is:" + average);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[8];
            for(int i=0;i<8;i++)
            {
                s[i] = new Student();
                Console.WriteLine("enter the roll no");
                s[i].Rollno = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the mark 1");
                s[i].sub1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the mark 2");
                s[i].sub2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the mark 3");
                s[i].sub3 = int.Parse(Console.ReadLine());
               
                s[i].show();
            }
            Console.ReadKey();
        }
    }
}

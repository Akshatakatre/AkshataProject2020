using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Student
    {
        public string Name { get; set; }
        public int Roll_no { get; set; }
        public void getData()
        {
            Name = "John";
            Roll_no = 2;
        }
        public void showData()
        {
            Console.WriteLine("student name is:" + Name);
            Console.WriteLine("student roll no is:" + Roll_no);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getData();
            s.showData();
            Console.ReadKey();
        }
    }
}

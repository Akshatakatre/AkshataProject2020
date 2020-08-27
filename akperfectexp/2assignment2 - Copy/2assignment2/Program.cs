using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment2
{
    public class StudentDetails
    {
        public static string Name = "Sam";
        public static string Name1 = "John";
        public int Rollno { get; set; }
        public double Phoneno { get; set; }
        public string Address { get; set; }
        public void setData(int rollno, double pno, string address)
        {
            Rollno = rollno;
            Phoneno = pno;
            Address = address;
        }
        public void showData()
        {
            Console.WriteLine("student 1 name is:" + Name);
            Console.WriteLine("student roll no is:" + Rollno);
            Console.WriteLine("student phone no is:" + Phoneno);
            Console.WriteLine("student address is:" + Address);
        }
        public void Data()
        {
            
            Console.WriteLine("student 2 name is:" + Name1);
            Console.WriteLine("student roll no is:" + Rollno);
            Console.WriteLine("student phone no is:" + Phoneno);
            Console.WriteLine("student address is:" + Address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails s = new StudentDetails();
            Console.WriteLine("enter the roll no");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("enter phone no");
            double pn = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the address");
            string a = Convert.ToString(Console.ReadLine());
            StudentDetails s1 = new StudentDetails();
            Console.WriteLine("enter the roll no");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter phone no");
            double pn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the address");
            string a1 = Convert.ToString(Console.ReadLine());
            s.setData(r, pn, a);
            s.showData();
            s1.setData(r1, pn1, a1);
            s1.Data();
            Console.ReadKey();
        }
    }
}



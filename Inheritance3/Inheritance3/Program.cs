using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double PhoneNumber { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public void data()
        {
            Console.WriteLine("enter the name");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the age");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the phone number");
            PhoneNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the address");
            Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the salary");
            Salary = float.Parse(Console.ReadLine());
        }
        public void printSalary()
        {
            Salary = 100000;
            Console.WriteLine("the salary of the employee is:" + Salary);
        }
        public void display()
        {
            Console.WriteLine("the name of the  is:" + Name);
            Console.WriteLine("the age of the  is:" + Age);
            Console.WriteLine("the phone number of the  is:" + PhoneNumber);
            Console.WriteLine("the salary of the  is:" + Salary);
        }
    }
    class Employee : Member
    {
        public string Spelization { get; set; }
        public string Department { get; set; }
        public void get()
        {
            Console.WriteLine("enter the specialization of the employee");
            Spelization = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the department of the employee ");
            Department = Convert.ToString(Console.ReadLine());
        }
    }
    class Manager:Member
    {
        public string Spelization { get; set; }
        public string Department { get; set; }
        public void show()
        {
            Console.WriteLine("enter the specialization of the manager");
            Spelization = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the department of the manaer ");
            Department = Convert.ToString(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Member m = new Member();
            Employee e = new Employee();
            Manager mg = new Manager();
            
            e.data();
            e.get();
            e.display();
            mg.data();
            mg.show();
            mg.display();
            m.printSalary();
            Console.ReadKey();
        }
    }
}

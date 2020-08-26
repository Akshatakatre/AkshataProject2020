using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment12


{
    class Employee
    {
        public int salary { get; set;}
        public int hours { get; set; }
        public void getInfo(int Salary,int Hours)
        {
            salary = Salary;
            hours = Hours;
        }
        public void AddSal()
        {
            if(salary==500)
            {
                salary = salary + 10;
                Console.WriteLine("the incremented salary is :" + salary);
            }
        }
        public void AddWork()
        {
            if(hours>6)
            {
                salary=salary+5;
                Console.WriteLine("extra work salary is :" + salary);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("enter the salary");
            int Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the hours");
            int Hours = int.Parse(Console.ReadLine());
            e.getInfo(Salary, Hours);
            e.AddSal();
            e.AddWork();
            Console.ReadKey();
        }
    }
}

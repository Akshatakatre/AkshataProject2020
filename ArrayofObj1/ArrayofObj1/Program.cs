using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofObj1
{
    class Employee
    {
        public string name { get; set; }
        public double salary { get; set; }
        public int date { get; set; }
        public void get(string name,double salary,int date)
        {
            this.name = name;
            this.salary = salary;
            this.date = date;
        }
        public void show()
        {
            Console.WriteLine("the name of the employee is:" + name);
            Console.WriteLine("the salary of the employee is:" + salary);
            Console.WriteLine("the date of joining  of the employee is:" + date);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            double s;
            int d;
            int i;
            Employee[] e = new Employee[10];
            for( i=0;i<10;i++)
            {
                e[i] = new Employee();
                Console.WriteLine("enter the name of employee");
                e[i].name = Console.ReadLine();
                Console.WriteLine("enter the salary of employee");
                e[i].salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the date of joining of employee");
                e[i].date = int.Parse(Console.ReadLine());
                 e[i].get(e[i].name, e[i].salary, e[i].date);
                 e[i].show();
            }
            Console.ReadKey();
         }
    }
}

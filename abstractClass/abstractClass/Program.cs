using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    abstract class employee
    {
        public string empName { get; set; }
        public double salary { get; set; }
        public abstract void getEmpDetails(string name, double sal);
        public virtual void show()
        {
            Console.WriteLine("employee name is :" + empName);
            Console.WriteLine("employee salary is:" + salary);
        }
    }
    class Edata : employee
    {
        public override void getEmpDetails(string name, double sal)
        {
            empName = name;
            salary = sal;
        }
        public  override void show()
        {
            Console.WriteLine("employee name is :" + empName);
            Console.WriteLine("employee salary is:" + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee e = new Edata();
            Console.WriteLine("enter the name");
            string n = Console.ReadLine();
            Console.WriteLine("enter salary");
            double s = Convert.ToDouble(Console.ReadLine());
            e.getEmpDetails(n, s);
            e.show();
            Console.ReadKey();
        }
    }
}

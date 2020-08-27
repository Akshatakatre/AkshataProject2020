using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @const
{
    class employee
    {
        public int eid;
         public string name;
       public float salary=21000;
         public static int bonus=5000;
        public employee()
        {
            eid = 26;
            name = "akshu";
            salary = 35999;

        }
        public  employee(int i,string n,float s)
        {
            eid = i;
            name = n;
            salary = s;
        }
        public employee(int bonus)
        {
            eid = 11;
            name = "ak";
            salary = salary + bonus;
        }
         static employee()
        {
            bonus =900;
        }

        
        public void dis()
        {
            Console.WriteLine("bonus is" + bonus);
        }
        public void show()
        {
            Console.WriteLine("employee id is:" + eid);
            Console.WriteLine("employee name is:" + name);
            Console.WriteLine("employee salary is:" + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            employee e = new employee();
            e.show();
            employee e1 = new employee(23,"akshata",25000);
            e1.show();
            employee e2 = new employee(1000);
            e2.show();
            employee e3 = new employee();
            e3.dis();
            Console.ReadKey();

        }
    }
}

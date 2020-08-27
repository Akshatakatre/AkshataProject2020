using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class EmpData
    {
        private int eid=02;
        private string ename="akshu";
        private float esal=23999;
        public int empid
        {
            get
            {
                return eid;
            }
            set
            {
                eid = value;
            }
        }
        public float empsal
        {
            get
            {
                return esal;
            }
            set
            {
                esal = value;
            }
        }
        public string empname
        {
            get
            {
                return ename;
            }

        }
    } 
    class Program
    {

        static void Main(string[] args)
        {
            EmpData e = new EmpData();
            int a=e.empid;
            string s = e.empname;
            float f = e.empsal;
            Console.WriteLine("employee id is:" + a);
            Console.WriteLine("employee name is:" + s);
            Console.WriteLine("employee salary is:" + f);
            Console.ReadKey();

        }
    }
}

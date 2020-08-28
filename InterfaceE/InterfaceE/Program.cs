using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceE
{
    interface Employee
    {
        string eName { get; set; }
    }
    interface EmpData
    {
        void set(string n);
    }
    class Edetails:Employee,EmpData
    {
        public string eName()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

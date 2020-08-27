using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
   abstract class Parent
    {
        abstract public void message();
        
    }
    class BaseOne:Parent
    {
       override public  void message()
        {
            Console.WriteLine("this is first sub class");
        }
    }
    class BaseTwo:Parent
    {
        override public  void message()
        {
            Console.WriteLine("this is second sub class");
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new BaseOne();
            p.message();
            Parent p1 = new BaseTwo();
            p1.message();
            Console.ReadKey();
        }
    }
}

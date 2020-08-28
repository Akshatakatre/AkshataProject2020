using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    class Uname
    {
        private static string name;
        public void set(string name)
        {
            Uname.name = name;
        }
        public static void show()
        {
            Console.WriteLine("name is:" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uname u = new Uname();
            u.set("akshu");
            Uname.show();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class Uname
    {
        public class nam
        {
            private string name;
            public void set(string n)
            {
                name = n;
                Console.WriteLine("name is:" + name);

            }
        }
        public int actno;
        public void setaccno(int a)
        {
            actno = a;
            Console.WriteLine("account no is:" + actno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uname.nam n = new Uname.nam();
            n.set("akshu");
            Uname u = new Uname();
            u.setaccno(02);
            Console.ReadKey();
        }
    }
}

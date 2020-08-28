using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structconst
{
    public struct constr
    {
        public string fname;
        public int age;


        public constr (string a,int b)
            {
            fname = a;
            age = b;

            }
        public void sdata()
        {
            Console.WriteLine("first name is:" + fname);
            Console.WriteLine("age is :" + age);
        }
    }
    class sprogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name and age");
            string a = Console.ReadLine();
            int b  = Convert.ToInt32(Console.ReadLine());
            constr s = new constr(a, b);
            s.sdata();
            Console.ReadKey();
        }
    }
}

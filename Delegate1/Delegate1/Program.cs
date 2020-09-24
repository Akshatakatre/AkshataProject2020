using System;

namespace Delegate1
{
    class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a,int b)
        {
            Console.WriteLine("(100+26)={0}", a + b);
        }

        public void substract(int a,int b)
        {
            Console.WriteLine("(100-20)={0}", a - b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            addnum del_obj1 = new addnum(p.sum);
            subnum del_obj2 = new subnum(p.substract);

            del_obj1(100, 26);
            del_obj2(100, 20);
            Console.ReadKey();

        }
    }
}

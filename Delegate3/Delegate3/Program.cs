using System;

namespace Delegate3
{
    class Program
    {
        public delegate void delmethods();

        public class p
        {
            public static void display()
            {
                Console.WriteLine("Good Morning.....! ");
            }
            public static void show()
            {
                Console.WriteLine("Good Afternoon.......!");
            }
            public void print()
            {
                Console.WriteLine("Good Evening......!");
            }
        }
        static void Main(string[] args)
        {
            delmethods del1 = p.show;
            delmethods del2 = new delmethods(p.display);
            p obj = new p();
            delmethods del3 = obj.print;
            del1();
            del2();
            del3();
            Console.ReadKey();
            
        }
    }
}

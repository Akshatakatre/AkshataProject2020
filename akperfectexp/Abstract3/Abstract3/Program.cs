using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract3
{
    abstract class Marks
    {
        public abstract void getPercentage();
    }
    class A : Marks
    {
        float per { get; set; }
        int mark1 { get; set; }
        int mark2 { get; set; }
        int mark3 { get; set; }
        int total { get; set; }
        public A(int m1,int m2,int m3)
        {
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
        }
        public override void getPercentage()
        {
            total = mark1 + mark2 + mark3;
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("the percentage of class A student is:" + per);
        }
    }
    class B:Marks
    {
        int mark1 { get; set; }
        int mark2 { get; set; }
        int mark3 { get; set; }
        int mark4 { get; set; }
        float per { get; set; }
        int total { get; set; }
        public B(int m1,int m2,int m3,int m4)
        {
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
            mark4 = m4;
        }
        public override void getPercentage()
        {
            total = mark1 + mark2 + mark3+mark4;
            per = (total / 400.0f) * 100.0f;
            Console.WriteLine("the percentage of class B student is:" + per);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mark one");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark two");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark three");
            int m3 = int.Parse(Console.ReadLine());
            Marks m = new A(m1,m2,m3);
            m.getPercentage();
            Console.WriteLine("enter mark one");
            int ma1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark two");
            int ma2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark three");
            int ma3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark four");
            int ma4 = int.Parse(Console.ReadLine());
            Marks ma = new B(ma1,ma2,ma3,ma4);
            ma.getPercentage();
            Console.ReadKey();

        }
    }
}

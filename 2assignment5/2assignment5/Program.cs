using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment5
{
    class Rectangle
    {
        public int s1, s2;
        public int s3, s4;
        public float area1, area2;
        public Rectangle(int a,int b,int c,int d)
        {
            s1 = a;
            s2 = b;
            s3 = c;
            s4 = d;
        }
        public void Area()
        {
            area1 = s1 * s2;
            Console.WriteLine("the area of the rectangle 1 is:" + area1);
            area2 = s3 * s4;
            Console.WriteLine("the area of the rectangle 2 is:" + area2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5, 5, 8);
            r.Area();
            Console.ReadKey();
        
        }
    }
}

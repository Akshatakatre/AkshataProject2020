using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment4
{
    class Triangle
    {
        public float area, perimeter;
        public int s1, s2, s3;
        public Triangle(int a,int b,int c)
        {
            s1 = a;
            s2 = b;
            s3 = c;
            area = (s1 * s2) / 2;
            Console.WriteLine("area=" + area);
            perimeter = s1 + s2 + s3;
            Console.WriteLine("perimeter= " + perimeter);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(3,4,5);
            Console.ReadKey();
        }
    }
}

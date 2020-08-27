using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment6
{
    class Area
    {
        public float length, breadth;
        public float area;
        public void setDim(float l,float b)
        {
            length = l;
            breadth = b;
        }
        public float getArea()
        {
            area = length * breadth;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area a = new Area();
           Console.WriteLine("enter the length");
            float l = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the breadth");
            float b = Convert.ToSingle(Console.ReadLine());
            a.setDim(l, b);
            a.getArea();
            float result = a.getArea();
            Console.WriteLine("the area of rectangle is:" + result);
            Console.ReadKey();
        }
    }
}

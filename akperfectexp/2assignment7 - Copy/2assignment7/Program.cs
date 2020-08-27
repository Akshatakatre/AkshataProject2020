using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment7
{
    class Area
    {
        public float length, breadth,area;
        public Area(float l,float b)
        {
            length =l;
            breadth =b;
        }
        public float returnArea()
        {
            
            area = length * breadth;
            return area;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
             float l, b;
           
           Console.WriteLine("enterthe length");
             l = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enterthe breadth");
             b = Convert.ToSingle(Console.ReadLine());
            Area a = new Area(l,b);
            float result=a.returnArea();
            Console.WriteLine("the area of rectangle is:" + result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance5
{
    class Rectangle
    {
        public float length { get; set; }
        public float breadth { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(float l,float b)
        {
            length = l;
            breadth = b;
        }

        public void area()
        {
            Area = length * breadth;
            Console.WriteLine("the area of the rectangle is:" + Area);
        }
        public void perimeter()
        {
            Perimeter = 2 * (length + breadth);
            Console.WriteLine("the perimeter of rectangle is:" + Perimeter);
        }
    }
    class Square : Rectangle
    {
        public float side { get; set; }
        public Square(float s)
        {
            side = s;

        }
        public void display()
        {
            Console.WriteLine("the side of the square is:" + side);
        }
        public new void area()
        {
            Area = side * side;
            Console.WriteLine("the area of the square is:" + Area);
        }
        public new void perimeter()
        {
            Perimeter = 2 * (side + side + side + side);
            Console.WriteLine("the perimeter of square is:" + Perimeter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float s=0;
            Square[] sa = new Square[10];
            for(int i=0;i<10;i++)
            {
                Square sq = new Square(s);
               
                Console.WriteLine("enter the side of the square");
                 s=float.Parse(Console.ReadLine());
                sa[i] = new Square(s);
                sa[i].area();
            }
            Console.ReadKey();
        }
    }
}

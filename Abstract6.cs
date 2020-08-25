using System;

namespace Abstract6
{
    abstract class Shape
    {
        abstract public void RectangleArea(float l,float b);
        abstract public void SquareArea(float s);
        abstract public void CircleArea(double r);
    }
    class Area : Shape
    {
        public float length { get; set; }
        public float breadth { get; set; }
        public float areaofrectangle { get; set; }
        public float side { get; set; }
        public float areaofsquare { get; set; }
        public double radius { get; set; }
        public double areaofcircle { get; set; }
        public override void RectangleArea(float l,float b)
        {
            length = l;
            breadth = b;
            areaofrectangle = length * breadth;
            Console.WriteLine("the area of the rectangle is :" + areaofrectangle);
        }
        public override void SquareArea(float s)
        {
            side = s;
            areaofsquare = side * side;
            Console.WriteLine("the area of the square is:" + areaofsquare);
        }
        public override void CircleArea(double r)
        {
            radius = r;
            areaofcircle = 3.14* radius * radius;
            Console.WriteLine("the area of the circle is:" + areaofcircle);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            Console.WriteLine("enter the length");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the breadth");
            float b = float.Parse(Console.ReadLine());
            a.RectangleArea(l, b);
            Console.WriteLine("enter the side of square");
            float s = float.Parse(Console.ReadLine());
            a.SquareArea(s);
            Console.WriteLine("enter the radius of the circle");
            double r = double.Parse(Console.ReadLine());
            a.CircleArea(r);
            Console.ReadKey();


            Console.WriteLine("Hello World!");
        }
    }
}

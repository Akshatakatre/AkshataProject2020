using System;

namespace Delegate2
{
    class Rectangle
    {
        public delegate void rectangle(double height, double width);
        
        public void area(double height,double width)
        {
            Console.WriteLine("Area of rectangle is:{0}", width * height);
        }

        public void perimeters(double height,double width)
        {
            Console.WriteLine("perimeter is :{0}", 2 * (height + width));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rectangle rectdele = new rectangle(rect.area);
            rectdele += rect.perimeters;
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();
            rectdele.Invoke(16.3, 10.3);
            Console.ReadLine();


        }
    }
}

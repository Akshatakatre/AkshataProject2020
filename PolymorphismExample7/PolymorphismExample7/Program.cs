using System;

namespace PolymorphismExample7
{
    class Program
    {
        public class Shape
        {
            public void Area(float r)
            {
                float a = (float)3.14 * r;
                  
                Console.WriteLine("Area of a circle: {0}", a);
            }
            public void Area(float l, float b)
            {
                float x = (float)l * b;
              
                Console.WriteLine("Area of a rectangle: {0}", x);
            }
            public void Area(float a, float b, float c)
            {
                float s = (float)(a * b * c) / 2;
                  
                Console.WriteLine("Area of a circle: {0}", s);
            }
        }
        static void Main(string[] args)
        {
            Shape ob = new Shape();
            ob.Area(2.0f);
            ob.Area(20.5f, 30.5f);
            ob.Area(2.6f, 3.6f, 4.6f);
            Console.ReadKey();
        }
    }
}

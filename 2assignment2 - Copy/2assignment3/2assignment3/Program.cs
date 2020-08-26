using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment3
{
    public class Triangle
    {
        public float area, perimeter;
        public int s1, s2, s3;
        Triangle()
        {
            s1 = 3;
            s2 = 4;
            s3 = 5;
            area = (s1 * s2) / 2;
            Console.WriteLine("area of triangle is:" + area);
            perimeter = s1 + s2 + s3;
            Console.WriteLine("perimeter of triangle is:" + perimeter);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Triangle t = new Triangle();
                Console.ReadKey();
            }
        }
    }
}

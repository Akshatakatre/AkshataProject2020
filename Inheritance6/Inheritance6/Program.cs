using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance6
{
    class Shape
    {
        public void print()
        {
            Console.WriteLine("this is shape class");
        }
    }
    class Rectangle:Shape
    {
        public new void print()
        {
            Console.WriteLine("this is rectangle shape");
        }
    }
    class Circle:Rectangle
    {
        public new void print()
        {
            Console.WriteLine("this is circle shape");
        }
    }
    class Square:Rectangle
    {
        public new void print()
        {
            Console.WriteLine("this is square is a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
                s.print();
            Rectangle r = new Square();
            r.print();
            Console.ReadKey();
        }
    }
}

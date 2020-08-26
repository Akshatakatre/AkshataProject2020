using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment11
{
    class AddDistance
    {
        public float inch1 { get; set; }
        public float inch2 { get; set; }
        public float feet1 { get; set; }
        public float feet2 { get; set; }
        public float dis1 { get; set; }
        public float dis2 { get; set; }
        public void calculate()
        {
            Console.WriteLine("enter the inch 1");
            inch1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the inch 2");
            inch2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the feet 2");
            feet1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the feet 2");
            feet2 = Convert.ToSingle(Console.ReadLine());
            dis1 = inch1 + inch2;
            Console.WriteLine("the total of inches is:" + dis1);
            dis2 = feet1 + feet2;
            Console.WriteLine("the total of feets is :" + dis2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AddDistance a = new AddDistance();
            a.calculate();
            Console.ReadKey();
        }
    }
}

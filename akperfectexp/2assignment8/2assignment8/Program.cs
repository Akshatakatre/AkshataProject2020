using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment8
{
    class Average
    {
        public float number1, number2, number3;
        public float average,sum;
        public void calculate()
        {
            Console.WriteLine("enter first number");
            number1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter second number");
            number2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter third number");
            number3 = Convert.ToSingle(Console.ReadLine());
            sum = number1 + number2 + number3;
            Console.WriteLine("the sum of 3 numbers is: " + sum);
            average = sum / 3;
            Console.WriteLine("the average of 3 number is:" + average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Average a = new Average();
            a.calculate();
           Console.ReadKey();
        }
    }
}

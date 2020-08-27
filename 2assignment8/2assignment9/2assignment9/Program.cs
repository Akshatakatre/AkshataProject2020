using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment9
{
    class Complex
    {
        public float realnumber1 { get; set; }
         public float imaginarynumber1 { get; set; }
        public int I1 { get; set; }
        public float realnumber2 { get; set; }
        public float imaginarynumber2 { get; set; }
        public int I2 { get; set; }
        public float total1 = 0, total2 = 0, diff = 0, result = 0, res;
        public void inData()
        {
            Console.WriteLine("enter the real number1");
            realnumber1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the imaginary number1");
            imaginarynumber1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the value od I1 ");
            I1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the real number2");
            realnumber2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the imaginary number2");
            imaginarynumber2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the value od I2 ");
            I2 = int.Parse(Console.ReadLine());
           
        }
        public void sum()
        {
           
            total1 = realnumber1 + imaginarynumber1*(I1);
            total2 = realnumber2 + imaginarynumber2 * (I2);
            res = total1 + total2;
            Console.WriteLine("the sum of the number is :" + total1);
            Console.WriteLine("the sum of the number is :" + total2);
            Console.WriteLine("the sum of two complex number is" + res);
        }
        public void difference()
        {
            diff = total2 - total1;
            Console.WriteLine("the difference between the two number is :" + diff);
        }
        public void product()
        {
            result = total1 * total2; ;
            Console.WriteLine("the product of two number is:"+result);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            /* Console.WriteLine("enter the real number");
             float r = Convert.ToSingle(Console.ReadLine());
             Console.WriteLine("enter the imaginary number");
             float inum = Convert.ToSingle(Console.ReadLine());
             //Complex c = new Complex();*/
            c.inData();
            c.sum();
            c.difference();
            c.product();
            Console.ReadKey();

        }
    }
}

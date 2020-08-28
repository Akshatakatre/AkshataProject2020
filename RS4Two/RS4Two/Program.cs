using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS4Two
{
    public class Number
    {
        public float sum=1.0f;
        public void cal()
        {
            for (int denominator = 2; denominator <= 8; )
            {
                for (int divident = 3; divident <= 7; )
                {
                    sum = sum + (divident / denominator);
                    divident = divident + 2;
                    denominator = denominator + 2;
                }
                //denominator = denominator + 2;
            }
            Console.WriteLine("sum is:" + sum);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Number n = new Number();
                n.cal();
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS4One
{
    public class Calculate
    {
        public float sum=1.0f;
        public void cal()
        {
            for (float denominator = 2; denominator <= 50; denominator++)
            {
                sum = sum + (1 / denominator);
            }
            Console.WriteLine("sum is" + sum);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Calculate c = new Calculate();
                c.cal();
                Console.ReadKey();

            }
        }
    }
}

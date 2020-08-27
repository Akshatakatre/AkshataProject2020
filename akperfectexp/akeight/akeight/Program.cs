using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akeight
{
   public class Program
    {
       public static int fab(int n)
        {
            int a,i,n1=0,n2=1,n3=0;
            a = n;
            Console.WriteLine("fibonacci series sequence is:");
            Console.WriteLine("fibonacci seriec is:"+n1);
            Console.WriteLine("fibonacci series is:"+n2);
            for( i=2;i<a;i++)
            {
                n3 = n1 + n2;
               // Console.WriteLine("fibonacci seriec is:" + n3);
                n1 = n2;
                n2 = n3;
                Console.WriteLine("fibonacci seriec is:" + n3);
            }
            //Console.WriteLine("fibonacci seriec is:" + n3);
            return n;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            int s = fab(n);
            Console.WriteLine("result is:"+s);
            Console.ReadKey();
        }
    }
}

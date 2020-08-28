using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3three
{
    class Program
    {
        int x, y;
        public void coord(int a,int b)
        {
            x = a;
            y = b;
            if(x>0 && y>0)
            {
                Console.WriteLine("coordinates belonge to quadrant I and quadrant IV");
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("coordinates belonge to quadrant II and quadrant III");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("coordinates belonge to quadrant III and quadrant IV");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("coordinates belonge to quadrant I and quadrant II");
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the coordinates");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.coord(a, b);
            Console.ReadKey();
        }
    }
}

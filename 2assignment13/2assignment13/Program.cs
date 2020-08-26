using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment13
{
   public class Matrix
    {
        public int rows { get; set; }
        public int column { get; set; }
        
        
        public Matrix()
        {
            rows =2;
            column =2;
        }
        public void set( )
        {
            Console.WriteLine("enter the rows ");
            Console.ReadLine();
            Console.WriteLine("enter the  columns");
            Console.ReadLine();
            Console.WriteLine("enter the elements of matrix");
            int[,] mat = new int[2, 2];
           
           
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("elements of matrix is ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write( mat[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int r, c;
        Matrix m = new Matrix();
        /*Console.WriteLine("enter the elements of row");
         r = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the elements of columns");
         c = int.Parse(Console.ReadLine());*/
        m.set();
           
            Console.ReadKey();
        }
    }
}

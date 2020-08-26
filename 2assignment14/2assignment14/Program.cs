using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment14
{
    class Matrix
    {
        public int row1 { get; set; }
        public int columns1 { get; set; }
        public int row2 { get; set; }
        public int columns2 { get; set; }
        //public int i, j;
        public int[,] add = new int[2, 2];
        public int[,] mult = new int[2, 2];
        public int[,] mat = new int[2, 2];
        public int[,] cat = new int[2, 2];
        public void getRows()
        {
            Console.WriteLine("enter the number of rows of matrix 1");
            row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of rows of matrix 2");
            row2 = int.Parse(Console.ReadLine());
        }
        public void getcolumns()
        {
            Console.WriteLine("enter the number of columns of matrix 1");
            columns1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of columns of matrix 2");
            columns2 = int.Parse(Console.ReadLine());
        }
        public void position()
        {
            Console.WriteLine("first matrix is");
            //int[,] mat = new int[2, 2];
            Console.WriteLine("enter the elements of the matrix");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("the matrix is");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
               
            }
            
            Console.WriteLine("second matrix is");
            int[,] cat = new int[2, 2];
            Console.WriteLine("enter the elements of the matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    cat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("the matrix is");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(cat[i, j] + "\t");
                }
                Console.WriteLine();
                
            }
            
        }
        public void AddMatrix()
        {
            Console.WriteLine("addition of matrix is");
            if(row1==row1 && columns1==columns1 && row2==row2 && columns2==columns2)
           {
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<2;j++)
                    {
                        add[i, j] = mat[i, j] + cat[i, j];
                        Console.Write(add[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
           }
            else
            {
                Console.WriteLine("matrix cannot be added");
            }
            
        }
        public void multiply()
        {
            Console.WriteLine("multiplication of matrix is");
            if (row1 == row2 && columns1 == columns2)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        mult[i, j] = mat[i, j] * cat[i, j];
                        Console.Write(mult[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("matrix cannot be multiply");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m.getRows();
            m.getcolumns();
            m.position();
            m.AddMatrix();
            m.multiply();
            Console.ReadKey();
        }
    }
}

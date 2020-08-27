using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofObj3
{
   
    class Program
    {
        public float height { get; set; }
        public int StudentNo { get; set; }
        public float average { get; set; }

        public void show(float s)
        {
           
            average = s / StudentNo;
            Console.WriteLine("the average height of the student is:" + average);

        }
        static void Main(string[] args)
        {
            
            float sum=0;
            Program p = new Program();
            Console.WriteLine("enter number of students");
            p.StudentNo=int.Parse(Console.ReadLine());
            Program[] s = new Program[p.StudentNo];
            
            //num = int.Parse(Console.ReadLine());
            for (int i=0;i< s.Length; i++)
            {
                 s[i] = new Program();
                
                Console.WriteLine("enter the height of student");
                s[i].height = float.Parse(Console.ReadLine());
                sum = sum + s[i].height;
                
            }
            p.show(sum);
            Console.ReadKey();
        }
    }
}

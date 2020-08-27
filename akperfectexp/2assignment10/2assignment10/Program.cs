using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment10
{
    /*class Employee
    {
        public string name { get; set; }
        public int yJoin { get; set; }
        public double salary { get; set; }
        public string address { get; set; }
        public void getData()
        {
       
            Console.WriteLine("Name   Year of joining    Address   Salary ");
            Console.WriteLine("{0}     {1,2,3}    {4}   {5}  ", name, yJoin, address, salary);
            for (int i=0;i<3;i++)
            {
                Console.WriteLine("{0}     {1,2,3}    {4}   {5}  ", name, yJoin, address, salary);

            }
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            string name, address;
             int yJoin;
             double salary;
         
             int d;

            for( d=0;d<3;d++)
            {
              
                Console.WriteLine("enter the name");
               name= Console.ReadLine();
                Console.WriteLine("enter the year of joining");
               yJoin =int.Parse( Console.ReadLine());
                Console.WriteLine("enter the addresss");
               address = Console.ReadLine();
                Console.WriteLine("enter the salary");
                 salary = Convert.ToDouble(Console.ReadLine());
                
            }
             
       

            Console.WriteLine("Name   Year of joining    Address   Salary ");
            Console.WriteLine("{0}     {1,2,3}    {4}   {5}" ,name,yJoin,address,salary   );
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}     {1,2,3}    {4}   {5}  ", name, yJoin, address, salary);

            }  
            Console.ReadKey();
        }
    }
}

using System;

namespace ConstructorExample
{
    class Program
    {
        private string month { get; set; }
        private int year { get; set; }
         
        public Program(Program s)
        {
            month = s.month;
            year = s.year;
        }
 
        public Program(string month, int year)
        {
            this.month = month;
            this.year = year;
        }
        
        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                         "\nYear: " + year.ToString();
            }
        }
        static void Main(string[] args)
        {
            Program g1 = new Program("March", 2020);
 
            Program g2 = new Program(g1);

            Console.WriteLine(g2.Details);
            Console.ReadKey();
        }
    }
}

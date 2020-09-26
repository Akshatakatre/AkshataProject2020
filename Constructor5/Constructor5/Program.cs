using System;

namespace Constructor5
{
    class Program
    {
        public string Name { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int sum { get; set; }

        public Program()
        {
            Console.WriteLine("This is parameterless constructor");
        }
        public Program(string n)
        {
            Name = n;
            Console.WriteLine("Name is : " + n);
        }
        public Program(int a,int b)
        {
            num1 = a;
            num2 = b;
            sum = num1 + num2;
            Console.WriteLine("Addition of two number is : " + sum);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1 = new Program("Tom&Jerry");
            Program p2 = new Program(26, 2);
            Console.ReadKey();

        }
    }
}

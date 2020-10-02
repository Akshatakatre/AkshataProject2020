using System;

namespace InterfaceExample5
{
    interface IStudent
    {
        string Name
        {
            get;
            set;
        }
        void study();
    }

    public class Student : IStudent
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void study()
        {
            Console.WriteLine("Study");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("Enter Student name: ");
            s.Name = System.Console.ReadLine();
            Console.WriteLine("Student name: {0}", s.Name);
            s.study();
            Console.ReadKey();
        }
    }
}

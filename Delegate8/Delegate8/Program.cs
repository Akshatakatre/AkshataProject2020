using System;

namespace Delegate8
{
    public delegate void NameDelegate(string msg);

    public class Person
    {
        public string firstName;
        public string secondName;

        public Person(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public void ShowFirstName(string msg)
        {
            Console.WriteLine(msg + this.firstName);
        }

        public void ShowSecondName(string msg)
        {
            Console.WriteLine(msg + this.secondName);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var per = new Person("Akshata", "Katre");

            var nDelegate = new NameDelegate(per.ShowFirstName);
            nDelegate("First name : ");

            nDelegate = new NameDelegate(per.ShowSecondName);
            nDelegate("Last name : ");
            Console.ReadKey();
        }
    }
}

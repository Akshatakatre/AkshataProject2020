using System;

namespace InterfaceExample3
{
    interface IFlyable
    {
        void fly();
    }
    interface IEatable
    {
        void eat();
    }

    class Parrot : IFlyable, IEatable
    {

        public void eat()
        {
            Console.WriteLine("Parrot eating");
        }
        //Implement method of interface
        public void fly()
        {
            Console.WriteLine("Parrot flying");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.eat();
            p.fly();
            Console.ReadKey();
        }
    }
}

using System;

namespace InterfaceExample7
{
    interface IFirstInterface
    {
        void myMethod(); 
    }

    interface ISecondInterface
    {
        void myOtherMethod(); 
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Hello.... ");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("How are you..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
            Console.ReadKey();
        }
    }
}

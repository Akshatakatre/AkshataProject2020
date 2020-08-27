using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    abstract class Bank
    {
        abstract public void getBalance();
    }
    class A:Bank
    {
        public override void getBalance()
        {
            int balance=100;
            Console.WriteLine("the balance of class A is :$" + balance);
        }
    }
    class B : Bank
    {
        public override void getBalance()
        {
            int balance = 150;
            Console.WriteLine("the balance of class B is :$" + balance);
        }
    }
    class C:Bank
    {
        public override void getBalance()
        {
            int balance = 200;
            Console.WriteLine("the balance of class C is :$" + balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new A();
            b.getBalance();
            Bank b1 = new B();
            b1.getBalance();
            Bank b2 = new C();
            b2.getBalance();
            Console.ReadKey();

        }
    }
}

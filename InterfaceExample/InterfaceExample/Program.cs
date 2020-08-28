using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface Account
    {
         void deposit(double amt);
    }
    interface Account1:Account
    {
        void showBalance();
    }
    class saving:Account1
    {
        public double balance = 2000;
        public void deposit(double amt)
        {
            balance = balance + amt;
            Console.WriteLine("balance is:" + balance);
        }
        public void showBalance()
        {
            Console.WriteLine("balance is:" + balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new saving();
            Account1 a1 = new saving();
            Console.WriteLine("enter the amount");
            double b = Convert.ToDouble(Console.ReadLine());
            a.deposit(b);
            a1.showBalance();
            //Console.WriteLine("balance is:" + balance);
            Console.ReadLine();
        }
    }
}

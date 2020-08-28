using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticbank
{
    class Bankacc
    {
        public decimal bal = 2000;
        public string name;
        public static decimal interest = 200;
        public void Withdraw(string n, decimal amount)
        {
            name = n;
            bal = bal - amount;
            Console.WriteLine("amount withdraw {0} bal is {1}", name, bal);

        }
        public void Deposit(string n,decimal amount)
        {
            name = n;
            bal = bal + amount + interest;
            Console.WriteLine("amount deposit {0} bal is {1}", name, bal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bankacc b = new Bankacc();
            Console.WriteLine("enter the name and amount");
            b.name = Console.ReadLine();
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter deposit or withdraw");
            string t = Console.ReadLine();
            Bankacc.interest = 500;
            switch(t)
            {
                case "Deposit":
                    b.Deposit(b.name, amt);
                    break;
                case "Withdraw":
                    b.Withdraw(b.name, amt);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Bankacc ba = new Bankacc();
            Console.WriteLine("enter the name and amount");
            ba.name = Console.ReadLine();
            amt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter deposit and withdraw");
            t = Console.ReadLine();
            switch(t)
            {
                case "Deposit":
                    ba.Deposit(ba.name, amt);
                    break;
                case "Withdraw":
                    ba.Withdraw(ba.name, amt);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.ReadKey();

        }
    }
}

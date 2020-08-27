using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacc
{
    class Bank
    {
        private decimal balance=2000;
        private string name;
        public void Withdraw(string n,decimal amount)
        {
            name = n;
            balance = balance - amount;
            Console.WriteLine("amount withdraw {0} bal is {1}", name, balance);

        }
        public void deposit(string n,decimal amount)
        {
            name = n;
            balance = balance + amount;
            Console.WriteLine("amount deposit {0} bal is {1}", name, balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Console.WriteLine("enter the name and amount");
            string n = Console.ReadLine();
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter deposite and withdraw");
            string t = Console.ReadLine();
            switch(t)
            {
                case "deposit":
                    b.deposit(n, amt);
                    break;
                case "Withdraw":
                    b.Withdraw(n, amt);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObject
{
    class BankAcc
    {
        public string name;
        public decimal bal = 2000;
        public static decimal interest = 200;
        public void Withdraw(string n,decimal amount)
        {
            name = n;
            bal = bal - amount;
            Console.WriteLine("amount withdraw {0} bal is {1}", name, bal);
        }
        public void Deposit(string n,decimal amount)
        {
            name = n;
            bal = bal + amount + interest;
            Console.WriteLine("amount withdraw {0} bal is {1}", name, bal);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            BankAcc[] b = new BankAcc[3];
            for(int i=0;i<3;i++)
            {
                b[i] = new BankAcc();
                Console.WriteLine("enter the name and amount");
                b[i].name = Console.ReadLine();
                decimal amt = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("enter deposit or withdraaw");
                string t = Console.ReadLine();
                switch(t)
                {
                    case "Deposit":
                        b[i].Deposit(b[i].name, amt);
                        break;
                    case "Withdraw":
                        b[i].Withdraw(b[i].name, amt);
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

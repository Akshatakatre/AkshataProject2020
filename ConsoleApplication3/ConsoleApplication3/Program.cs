
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAbstract
{
    class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Balance = 2000;
        }
        public virtual string deposit(double amount)
        {
            Console.WriteLine("base class");
            return "account of base class deposit method";
        }
        public string showBalance()
            {
            Console.WriteLine("base class");
            return "balance amount of account number :" + AccountNumber + "is" + Balance;
        }
    }
    class saving:Account
    {
        public double Interest { get; set; }
         
        public override string deposit(double amount)
        {
            Interest = 500;
            Balance = Balance + amount + Interest;
            return "ammount deposit successfully with interest,balance is:" + Balance;

        }
    }
    class Current:Account
    {
        public override string deposit(double amount)
        {
            
            Balance = Balance + amount ;
            return "ammount deposit successfully without interest,balance is:" + Balance;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int actno;
            double amt;
            Console.WriteLine("enter account number");
            actno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter ammount");
            amt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter account type(saving or current)");
            string accounttype = Console.ReadLine();

            string result = null;
            string result1 = null;
            Account a = null;
            if(accounttype=="saving")
            {
                a = new saving();
            }
            else if(accounttype=="current")
            {
                a = new Current();
            }
            a.AccountNumber = actno;
            result = a.deposit(amt);
            result1 = a.showBalance();
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}

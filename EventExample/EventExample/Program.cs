using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Account
    {
        public int balance = 1000;
        public string deposit(int amt)
        {
            balance = balance + amt;
            return "amount depositated balance is:" + balance;
        }
        public string withdraw(int amt)
        {
            balance = balance - amt;
            return "amount withdraw is " + balance;
        }
    }
    class Program
    {
        public delegate string accountDel(int amt);
        private event accountDel accevent;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter the amount");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("enter deposit or withdraw");
            string t = Console.ReadLine();

            Account a = new Account();
            accountDel ad = null;
            switch(t)
            {
                case "deposit":
                    p.accevent += new accountDel(a.deposit);
                    break;
                case "withdraw":
                    p.accevent += new accountDel(a.withdraw);
                    break;
                default:
                    Console.WriteLine("please enter deposit or withdraw");
                    break;
            }   
            if(p.accevent!=null)
            {
                string result = p.accevent(amount);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}

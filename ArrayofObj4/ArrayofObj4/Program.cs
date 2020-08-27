using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofObj4
{
    class BankAccount
    {
        public string NameofDepositor { get; set; }
        public string AddresofDepositor { get; set; }
        public string TypeofAccount { get; set; }
        public float BalanceofAccount { get; set; }
        public int NumberofTransactions { get; set; }
        public void UniqueAccountNumber()
        {
             string accNo = "BA1000";
            
        }
        public void Balance()
        {
            Console.WriteLine("balance of the depositor is:" + BalanceofAccount);
        }
        public void Deposit(float amount)
        {
            BalanceofAccount = BalanceofAccount + amount;
            Console.WriteLine("additional balance in account is:" + BalanceofAccount);
        }
        public void Withdraw(float amount)
        {
            BalanceofAccount = BalanceofAccount - amount;
            Console.WriteLine("withdraw balance in account is:" + BalanceofAccount);
        }
        public void ChangeAddress()
        {
            Console.WriteLine("enter new address of depositor");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter the number of depositor");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount");
            float a = float.Parse(Console.ReadLine());
            Program p = new Program();
            BankAccount[] ba = new BankAccount[num];
            for( i=0;i<ba.Length;i++)
            {
                ba[i] = new BankAccount();
                Console.WriteLine("enter the name of depositor ");
                ba[i].NameofDepositor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter the address of depositor ");
                ba[i].AddresofDepositor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter the account type of depositor ");
                ba[i].TypeofAccount = Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter the balance in account ");
                ba[i].BalanceofAccount = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter the number of transaction");
                ba[i].NumberofTransactions = int.Parse(Console.ReadLine());
            }
            ba[i].Balance();
            ba[i].Deposit(a);
            ba[i].Withdraw(a);
            ba[i].ChangeAddress();
            Console.ReadKey();
        }
    }
}

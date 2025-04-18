using System;

namespace BankBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the account number, quit to end?");
            string accountNumber = Console.ReadLine();
            while (accountNumber.ToLower() != "quit")
            {
                Console.WriteLine("What is the account name?");
                string accountName = Console.ReadLine();
                Console.WriteLine("What is the beginning balance?");
                decimal beginningBalance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What are the total deposits?");
                decimal totalDeposits = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What are the total withdrawals?");
                decimal totalWithdrawals = Convert.ToDecimal(Console.ReadLine());

                Banking transaction = new Banking(accountNumber, accountName, beginningBalance, totalDeposits, totalWithdrawals);
                transaction.ProcessTransaction();

                Console.WriteLine("What is the account number, quit to end?");
                accountNumber = Console.ReadLine();
            }
        }
    }
}

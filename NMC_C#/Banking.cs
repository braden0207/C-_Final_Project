using System;

namespace BankBalance
{
    public class Banking
    {
        private static int transactionCounter;

        static Banking()
        {
            transactionCounter = 0;
        }

        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal BeginningBalance { get; set; }
        public decimal TotalDeposits { get; set; }
        public decimal TotalWithdrawals { get; set; }
        public decimal EndingBalance { get; set; }

        public Banking(string accountNumber, string accountName, decimal beginningBalance, decimal totalDeposits, decimal totalWithdrawals)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            BeginningBalance = beginningBalance;
            TotalDeposits = totalDeposits;
            TotalWithdrawals = totalWithdrawals;
            transactionCounter++;
        }

        public void ProcessTransaction()
        {
            EndingBalance = BeginningBalance + TotalDeposits - TotalWithdrawals;

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine($" Transaction # {transactionCounter} Account # {AccountNumber} Account Name: {AccountName}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Beginning Balance: {BeginningBalance:C}");
            Console.WriteLine($" Total Deposits: {TotalDeposits:C}");
            Console.WriteLine($"Total Withdrawals: {TotalWithdrawals:C}");
            Console.WriteLine("~~~~~Your transactions are being processed~~~~~");

            if (EndingBalance < 0)
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine(" You do not have enough money in your account to complete this transaction");
                Console.WriteLine(" Your transactions have not been processed.");
                Console.WriteLine($" Your ending balance remains the same: {BeginningBalance:C}");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                EndingBalance = BeginningBalance;
            }
            else
            {
                Console.WriteLine($" Ending Balance: {EndingBalance:C}");
            }
        }
    }
}

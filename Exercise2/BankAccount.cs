using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class BankAccount
    {
        private string AccountNumber;
        private decimal Balance;
        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public void Deposite(decimal amount)
        {
            Balance = amount + Balance;
        }
        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
        }
        public void Output()
        {
            Console.WriteLine($"Your total balance is {Balance}");
        }
    }
}


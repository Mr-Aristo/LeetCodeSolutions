using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class BankAccount
    {
        private decimal balance;
        private string accountNumber; // field 

        public string AcountNumner
        {
            get => accountNumber;
            private set => accountNumber = value;
        }

        public decimal Balance
        {
            get => balance;
            private set => balance = value;
        }

        public BankAccount(string accountNum, decimal balance)
        {
            this.accountNumber = accountNum;
            this.balance = balance;

        }

        public void Deposit(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance += amount;
            }

        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }


        }

    }
}

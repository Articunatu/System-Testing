using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_xUnit
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {

        }

        public BankAccount(double _balance)
        {
            this.balance = _balance;
        }

        public double Balance { get { return balance; } }
        
        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance -= amount;
        }

        public void TransferTo(BankAccount otherAccount, double amount)
        {
            if (otherAccount == null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }
            Withdraw(amount);
            otherAccount.Add(amount);
        }
    }
}
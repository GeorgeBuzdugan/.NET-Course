using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laborator_6
{
    enum AccountType {
        SavingsAccount,
        CurrentAccount,
        InvestmentAccount
    }
    abstract class Account
    {
        private readonly string accountName;
        private readonly AccountType accountType;
        private readonly Guid guid = Guid.NewGuid();
        protected double balance = 0;
        public static int count = 0;

        public Account(AccountType accountType, string accountName)
        {
            this.accountType = accountType;
            this.accountName = accountName;
            Interlocked.Increment(ref count);
        }

        virtual public void Add(float sum)
        {
            balance += sum;
        }
        virtual public void Withdraw(float sum)
        {
            if (sum > balance)
            {
                Console.WriteLine("Insufficient funds");
                return;
            }
            balance -= sum;
        }

        override public string ToString()
        {
            return $"GUID: {guid}\tAccount Name: {accountName}\tAccount Type: {accountType}\tBalance: {balance}\t";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class SavingsAccount: Account
    {
        private readonly double interestRate;
        public SavingsAccount(string accountName, double interestRate): base(AccountType.SavingsAccount, accountName)
        {
            this.interestRate = interestRate;
        }

        public override void Add(float sum)
        {
            base.Add(sum);
            balance *= (1 + interestRate);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Interest Rate: {interestRate}";
        }
    }
}

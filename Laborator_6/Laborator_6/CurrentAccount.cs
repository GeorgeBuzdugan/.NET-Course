using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class CurrentAccount : Account
    {
        private readonly int ceil = 5000;
        public CurrentAccount(string accountName):base(AccountType.CurrentAccount, accountName) { }

        public override void Withdraw(float sum)
        {
            if (sum > balance + ceil)
            {
                Console.WriteLine("Insufficient funds");
                return;
            }
            balance -= sum;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Ceil: {ceil}";
        }
    }
}

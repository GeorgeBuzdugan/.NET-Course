using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_6
{
    class InvestmentAccount: Account
    {
        private readonly DateTime withdrawlPeriod;
        public InvestmentAccount(string accountName, DateTime withdrawlPeriod) : base(AccountType.SavingsAccount, accountName)
        {
            this.withdrawlPeriod = withdrawlPeriod;
        }

        public override void Withdraw(float sum)
        {
            if (withdrawlPeriod.Day != DateTime.Now.Day)
            {
                Console.WriteLine("Invalid withdrawl period");
            }
            base.Withdraw(sum);
        }


        public override string ToString()
        {
            return $"{base.ToString()}Withdrawl Period: {withdrawlPeriod.Day}";
        }
    }
}

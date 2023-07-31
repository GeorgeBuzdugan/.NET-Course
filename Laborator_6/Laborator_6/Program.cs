using System;

namespace Laborator_6
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount currentAccount = new CurrentAccount("Current Account");
            currentAccount.Add(100);
            currentAccount.Withdraw(200);
            currentAccount.Withdraw(5000);
            Console.WriteLine(currentAccount.ToString());
            SavingsAccount savingsAccount = new SavingsAccount("Saving Account", 0.01);
            savingsAccount.Add(50);
            savingsAccount.Withdraw(5000);
            Console.WriteLine(savingsAccount.ToString());
            InvestmentAccount investmentAccount = new InvestmentAccount("Investment Account", DateTime.Now);
            investmentAccount.Add(59);
            investmentAccount.Withdraw(31);
            Console.WriteLine(investmentAccount.ToString());
            InvestmentAccount investmentAccount1 = new InvestmentAccount("Investment Account", DateTime.Today.AddDays(1));
            investmentAccount1.Add(59);
            investmentAccount1.Withdraw(31);
            Console.WriteLine(investmentAccount1.ToString());
            Console.WriteLine($"Number of accounts created: {Account.count}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public class ClassicCard : IContactFullPayment
    {
        public void Insert()
        {
            Console.WriteLine("Insert the card into the machine.");
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} dollars.");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw the card.");
        }
    }
}

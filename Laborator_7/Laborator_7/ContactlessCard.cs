using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public class ContactlessCard : IContactFullPayment, IContactlessPayment
    {
        public void Insert()
        {
            Console.WriteLine("No need to insert the card.");
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} dollars.");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw the card.");
        }

        public void Tap()
        {
            Console.WriteLine("Tap the card on the machine.");
        }
    }
}

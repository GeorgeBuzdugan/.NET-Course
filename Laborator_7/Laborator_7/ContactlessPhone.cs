using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public class ContactlessPhone : IContactlessPayment
    {
        public void Tap()
        {
            Console.WriteLine("Tap the phone on the machine.");
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} dollars using the phone.");
        }
    }
}

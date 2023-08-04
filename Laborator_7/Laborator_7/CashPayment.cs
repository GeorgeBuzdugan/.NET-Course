using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public class CashPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Opening the safe.");
            Console.WriteLine($"Inserting {amount} into the safe.");
            Console.WriteLine("Closing the safe.");
            Console.WriteLine("Issuing a receipt.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public class PosPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Sending {amount} to POS.");
        }
    }

}

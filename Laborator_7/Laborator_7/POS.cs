using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public class POS
    {
        public void AcceptPayment(IContactFullPayment paymentMethod, double amount)
        {
            paymentMethod.Insert();
            paymentMethod.ProcessPayment(amount);
            paymentMethod.Withdraw();
        }

        public void AcceptPayment(IContactlessPayment paymentMethod, double amount)
        {
            paymentMethod.Tap();
            paymentMethod.ProcessPayment(amount);
        }

        public void AcceptPayment(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }

}

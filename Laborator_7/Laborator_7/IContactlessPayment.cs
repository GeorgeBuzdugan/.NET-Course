using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public interface IContactlessPayment
    {
        void Tap();
        void ProcessPayment(double amount);
    }
}

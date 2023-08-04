using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7
{
    public interface IContactFullPayment
    {
        void Insert();
        void ProcessPayment(double amount);
        void Withdraw();
    }
}

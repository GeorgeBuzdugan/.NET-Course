using System;

namespace Laborator_7
{
    class Program
    {
        static void Main(string[] args)
        {
            POS pos = new POS();

            ClassicCard classicCard = new ClassicCard();
            ContactlessCard contactlessCard = new ContactlessCard();
            ContactlessPhone contactlessPhone = new ContactlessPhone();

            double paymentAmount = 100.0;

            Console.WriteLine("Payment with classic card:");
            pos.AcceptPayment(classicCard, paymentAmount);

            Console.WriteLine("\nPayment with contactless card:");
            pos.AcceptPayment((IContactlessPayment)contactlessCard, paymentAmount);

            Console.WriteLine("\nPayment with contactless phone:");
            pos.AcceptPayment(contactlessPhone, paymentAmount);

            CashPayment cashPayment = new CashPayment();
            PosPayment posPayment = new PosPayment();

            Console.WriteLine("Cash payment:");
            pos.AcceptPayment(cashPayment, paymentAmount);

            Console.WriteLine("\nPOS payment:");
            pos.AcceptPayment(posPayment, paymentAmount);
        }
    }
}

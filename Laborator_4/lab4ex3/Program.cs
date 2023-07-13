using System;

namespace lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car tesla = new Car("Tesla", "CJ 02 ABC", 23);
            Car ford = new Car("Ford", "CJ 10 BCD", 55);
            tesla.AddPassenger("George Buzdugan");
            ford.AddPassenger("Andrei Andrei");

            Console.WriteLine($"{tesla.GetDescription()}\n{ford.GetDescription()}");
        }
    }
}

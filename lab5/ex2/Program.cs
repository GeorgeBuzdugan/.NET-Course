using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train("AllinOne Express");
            Locomotive locomotive = new Locomotive(300);
            FreightCar freightCar = new FreightCar(500, 1992, FreightType.Coal, 15);
            PeopleWagon peopleWagon = new PeopleWagon(600, 1998, 30);
            FirstClassWagon firstClassWagon = new FirstClassWagon(800, 2004, 50);

            train.AddWagon(locomotive);
            train.AddWagon(freightCar);
            train.AddWagon(peopleWagon);
            train.AddWagon(firstClassWagon);
            train.Open();
            train.Close();
            Console.WriteLine(train.ToString());
        }
    }
}

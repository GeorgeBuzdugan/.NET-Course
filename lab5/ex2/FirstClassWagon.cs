using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class FirstClassWagon : PeopleWagon
    {
        public FirstClassWagon(int mass, int fabricationYear, int numberOfPlaces) : base(mass, fabricationYear, numberOfPlaces)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Air Confitioner started");
        }

        public override void Close()
        {
            Console.WriteLine("Air Confitioner stopped");
        }
    }
}

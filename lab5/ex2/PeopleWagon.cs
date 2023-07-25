using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class PeopleWagon : Wagon
    {
        private int numberOfPlaces;

        public PeopleWagon(int mass, int fabricationYear, int numberOfPlaces) : base(mass, fabricationYear)
        {
            this.numberOfPlaces = numberOfPlaces;
        }

        public override void Close()
        {
            Console.WriteLine("Doors were close.");
        }

        public override void Open()
        {
            Console.WriteLine("Doors were opened");
        }

        public override string ToString()
        {
            return $"Vagon de persoane. Numar de locuri: {numberOfPlaces} {base.ToString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2
{
    class Train : Wagon
    {
        private readonly string name;
        private readonly List<Wagon> wagons = new List<Wagon>();

        public Train(string name): base()
        {
            this.name = name;
        }

        public override void Close()
        {
            wagons.ForEach(wagon => wagon.Close());
        }

        public override void Open()
        {
            wagons.ForEach(wagon => wagon.Open());
        }

        public void AddWagon(Wagon wagon)
        {
            wagons.Add(wagon);
        }

        public override string ToString()
        {
            return $"Numele trenului: {name}. {string.Join(", ", wagons.Select(wagn => wagn.ToString()))}";
        }
    }
}

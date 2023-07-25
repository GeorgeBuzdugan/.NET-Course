using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    abstract class Wagon
    {
        private readonly int mass = 0;
        private readonly int fabricationYear = 0;

        public Wagon(int mass, int fabricationYear)
        {
            this.mass = mass;
            this.fabricationYear = fabricationYear;
        }

        protected Wagon()
        {
        }

        public abstract void Open();
        public abstract void Close();

        public override string ToString()
        {
            return $"Mass: {mass}t, {fabricationYear}";
        }
    }
}

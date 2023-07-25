using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    enum FreightType
    {
        Cereal,
        Coal,
        Steel
    }
    class FreightCar : Wagon
    {
        private FreightType freightType;
        private int capacity;

        public FreightCar(int mass, int fabricationYear, FreightType freightType, int capacity) : base(mass, fabricationYear)
        {
            this.freightType = freightType;
            this.capacity = capacity;
        }

        public override void Close()
        {
           
        }

        public override void Open()
        {
           
        }

        public override string ToString()
        {
            return $"Vagon de marfa. Tip marfii: {freightType}. Cantitatea marfii: {capacity}. {base.ToString()}";
        }
    }
}

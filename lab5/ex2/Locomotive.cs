using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class Locomotive: Wagon
    {
        int power;

        public Locomotive(int power) : base()
        {
            this.power = power;
        }
        public override void Open()
        {
            Console.WriteLine("The locomotive has started.");
        }

        public override void Close()
        {
            Console.WriteLine("The locomotive has stopped.");
        }

        public override string ToString()
        {
            return $"Locomotiva putere {power}W";
        }
    }
}

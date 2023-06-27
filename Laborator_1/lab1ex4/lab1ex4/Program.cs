using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        /*
        Scrieti un program care va afisa semnul unui numar citit de la tastatura
        • Daca numarul este pozitiv, va afisa “+”
        • Daca numarul este negativ, va afisa “-”
        • Daca numarul este 0, va afisa “0”
        */
        {
            Console.WriteLine("Introduceti un numar: ");
            float numar = float.Parse(Console.ReadLine());
            if (numar > 0) Console.WriteLine("+");
            else if (numar == 0) Console.WriteLine("0");
            else Console.WriteLine("-");
        }
    }
}

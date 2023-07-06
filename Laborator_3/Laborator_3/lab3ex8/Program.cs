using System;

namespace lab3ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va afisa
            urmatoarea piramida a numerelor:
            */

            static int GetNumber()
            {
                Console.WriteLine("Introduceti numarul pana la care sa se afiseze piramida:\n");

                return int.Parse(Console.ReadLine());
            }
            
            static void RecursivePyramid(int number, int initialNumber)
            {
                if (number == initialNumber + 1)
                {
                    return;
                }

                for (int i = 0; i < number; i++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
                RecursivePyramid(number + 1, initialNumber);
            }

            RecursivePyramid(1, GetNumber());
        }
    }
}

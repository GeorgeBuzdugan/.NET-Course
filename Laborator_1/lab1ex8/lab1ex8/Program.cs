using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        /* Scrieti un program care interschimba valoarea a doua variabile intregi. */
        {
            int swap;
            Console.WriteLine("Introduceti prima valoare: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare: ");
            int secondNumber = int.Parse(Console.ReadLine());
            swap = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swap;
            Console.WriteLine("Prima variabila este acum: " + firstNumber);
            Console.WriteLine("A doua variabila este acum " + secondNumber);
        }
    }
}

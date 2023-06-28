using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        /*Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
        • Exemplu: citim ,9,0 Afisam : 0 9*/
        {
            Console.WriteLine("Introduceti primul numar:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            float secondNumber = float.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(secondNumber + "," + firstNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + "," + secondNumber);

            }
        }
    }
}

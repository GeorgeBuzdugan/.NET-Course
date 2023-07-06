using System;

namespace lab6ex7
{
    class Program
    {
        /*Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
        apelati-o si afisati-i rezultatul. */

        static void Main(string[] args)
        {
            static int GetNumber()
            {
                Console.WriteLine("Introduceti numarul pana la care sa se calculeze suma: \n");
                
                return int.Parse(Console.ReadLine());
            }

            static int RecursiveSum(int number)
            {
                if (number == 0)
                {
                    return 0;
                }
                return number + RecursiveSum(number - 1);
            }

            int number = GetNumber();
            Console.WriteLine($"\nSuma numerelor pana la {number} este egala cu: {RecursiveSum(number)}");
        }
    }
}

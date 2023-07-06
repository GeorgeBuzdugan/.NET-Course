using System;

namespace lab3ex1
{
    class Program
    {
        /*
         Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la
        randul sau citit de la tastatura.
        Scrieti functii care vor returna
        • Cel mai mare numar din vector
        • Cel mai mic numar din vector
        • Numerele divizibile cu 3
        • Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I
        rezultatul
        Optional
        • Numerele prime din vector
        Apelati functiile si afisati-le rezultatele.
        */

        static void Main(string[] args)
        {
            static int ReadNumberOfNumbers()
            {
                Console.WriteLine("Introduceti dimensiunea vectorului:\n");
                return int.Parse(Console.ReadLine());
            }

            static int[] ReadNumbers()
            {
                int numberOfNumbers = ReadNumberOfNumbers();
                int[] numbers = new int[numberOfNumbers];

                for (int i = 0; i< numberOfNumbers; i++)
                {
                    Console.WriteLine($"\nIntroduceti numarul cu indexul {i + 1}:\n");
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                return numbers;
            }

            static int ArrayMax(int[] numbers)
            {
                Array.Sort(numbers);
                return numbers[^1];
            }

            static int ArrayMin(int[] numbers)
            {
                Array.Sort(numbers);
                return numbers[0];
            }

            static int[] GetNumbersDivisibleByThree(int[] numbers)
            {
                return Array.FindAll(numbers, number => number % 3 == 0);
            }

            static int[] ReverseNumbers(int[] numbers)
            {     
                Array.Reverse(numbers);
                return numbers;
            }

            static int[] FindPrimeNumbers(int[] numbers)
            {
                static bool IsPrime(int number)
                {
                    for (int i = 2; i < number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }

                return Array.FindAll(numbers, number => IsPrime(number));
            }

            static string GetPrintArray(int[] numbers)
            {
                return string.Join(", ", numbers);
            }

            int[] numbers = ReadNumbers();
            Console.WriteLine($"\nCel mai mare numar din vector este: {ArrayMax(numbers)}\n");
            Console.WriteLine($"Cel mai mic numar din vector este: {ArrayMin(numbers)}\n");
            Console.WriteLine($"Numrele divizibile cu 3 sunt: {GetPrintArray(GetNumbersDivisibleByThree(numbers))}\n");
            Console.WriteLine($"Vectorul inversat este: {GetPrintArray(ReverseNumbers((numbers)))}\n");
            Console.WriteLine($"Numerele prime sunt: {GetPrintArray(FindPrimeNumbers((numbers)))}\n");

        }
    }
}

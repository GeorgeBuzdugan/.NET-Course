using System;

namespace Laborator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] exercitii =
            {
                "1: Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra.",
                "2: Scrieti o functie care va determina daca un numar este sau nu palindrom.",
                "3: Scrieti o functie care va determina daca un numar este sau nu numar prim.",
                "4: Scrieti o functie care va determina daca un numar este sau nu patrat perfect.",
                "5: Scrieti o functie care va afisa piramida numerelor pare, intre 2 si n, n fiind citit de la tastatura\n",
            };

            while (true)
            {
                Console.WriteLine("Alegeti un exercitiu:\n");
                foreach(string exercitiu in exercitii)
                {
                    Console.WriteLine(exercitiu);
                }
                int numarExercitiu = int.Parse(Console.ReadLine());
                switch (numarExercitiu)
                {
                    case 1:
                        Exercitiul_1();
                        break;
                    case 2:
                        Exercitiul_2();
                        break;
                    case 3:
                        Exercitiul_3();
                        break;
                    case 4:
                        Exercitiul_4();
                        break;
                    case 5:
                        Exercitiul_5();
                        break;
                    default:
                        Console.WriteLine("\nInvalid input\n");
                        break;
                }
            }

            /*Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi 
            determină media aritmetică a celor pare, n fiind citit de la tastatra*/

            static float CalculateEvenNumbersArithmeticAverage(int numberOfNumbers)
            {
                float sum = 0;
                float numberOfEvenNumbers = 0;
                
                for (int i = 0; i < numberOfNumbers; i++)
                {
                    Console.WriteLine("\nIntroduceti numarul cu indexul " + (i + 1) + " :\n");
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        sum += number;
                        numberOfEvenNumbers++;
                    }
                }
                return (sum / numberOfEvenNumbers);
            }

            static void Exercitiul_1()
            {
                Console.WriteLine("\nIntroduceti numarul de numere care vor fii introduse:\n");
                int numberOfNumbers = int.Parse(Console.ReadLine());
                Console.WriteLine("\nMedia aritmetica a numerelor pare introduse este egala cu: " + CalculateEvenNumbersArithmeticAverage(numberOfNumbers));
            }

            /*Scrieti o functie care va determina daca un numar este sau nu palindrom.*/
            static bool CheckPalindrome(int number)
            {
                int reverseNumber = 0;
                int temporaryNumber = number;

                while (temporaryNumber > 0)
                {
                    reverseNumber = reverseNumber * 10 + temporaryNumber % 10;
                    temporaryNumber /= 10;
                }
                if (reverseNumber == number)
                {
                    return true;
                }
                return false;
            }

            static void Exercitiul_2()
            {
                Console.WriteLine("\nIntroduceti numarul pe care doriti sa il testati daca este un palindrom:\n");
                int number = int.Parse(Console.ReadLine());
                if (CheckPalindrome(number))
                {
                    Console.WriteLine("\nNumarul introdus este un palindrom.\n");
                }
                else
                {
                    Console.WriteLine("\nNumarul introdus nu este un palindrom.\n");
                }
            }

            /*Scrieti o functie care va determina daca un numar este sau nu numar prim.
            Apelati-o si afisati-i rezultatul
            */

            static bool CheckIfPrime(int number)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            static void Exercitiul_3()
            {
                Console.WriteLine("\nIntroduceti numarul pe care doriti sa il testati daca este un numar prim:\n");
                int number = int.Parse(Console.ReadLine());
                if (CheckIfPrime(number))
                {
                    Console.WriteLine("\nNumarul introdus este un numar prim.\n");
                }
                else
                {
                    Console.WriteLine("\nNumarul introdus nu este un numar prim.\n");
                }
            }

            /*Scrieti o functie care va determina daca un numar este sau nu patrat perfect.
            Apelati-o si afisati-i rezultatul*/

            static bool CheckIfPerfectSquareRoot(int number)
            {
                if (Math.Sqrt(number) % 1 == 0)
                {
                    return true;
                }
                return false;
            }

            static void Exercitiul_4()
            {
                Console.WriteLine("\nIntroduceti numarul pe care doriti sa il testati daca este un patrat perfect:\n");
                int number = int.Parse(Console.ReadLine());
                if (CheckIfPerfectSquareRoot(number))
                {
                    Console.WriteLine("\nNumarul introdus este un patrat perfect.\n");
                }
                else
                {
                    Console.WriteLine("\nNumarul introdus nu este un patrat perfect.\n");
                }
            }

            /*Scrieti o functie care va afisa piramida numerelor pare, intre 2 si n, n fiind citit
            de la tastatura*/

            static void EvenPyramid(int number)
            {
                for (int i = 2; i <= number; i += 2)
                {
                    string line = "";
                    for (int j = 0; j < i / 2; j++)
                    {
                        if (line == "")
                        {
                            line = i.ToString();
                        }
                        else
                        {
                            line = line + " " + i;
                        }
                    }
                    Console.WriteLine(line);
                }
            }

            static void Exercitiul_5()
            {
                Console.WriteLine("\nIntroduceti numarul pana la care doriti sa fie afisata piramida: \n");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                EvenPyramid(number % 2 == 0 ? number : number + 1);
                Console.WriteLine();
            }
        }
    }
}

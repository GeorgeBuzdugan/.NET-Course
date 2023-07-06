using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            static string GetString()
            {
                Console.WriteLine("Introduceti un sir de caractere: \n");
                return Console.ReadLine();
            }

            static int CountVowels(string characterArray)
            {
                int vowels = 0;

                for (int i = 0; i < characterArray.Length - 1; i++)
                {
                    if (characterArray[i] == 'a' ||
                        characterArray[i] == 'e' ||
                        characterArray[i] == 'i' ||
                        characterArray[i] == 'o' ||
                        characterArray[i] == 'u' ||
                        characterArray[i] == 'A' ||
                        characterArray[i] == 'E' ||
                        characterArray[i] == 'I' ||
                        characterArray[i] == 'O' ||
                        characterArray[i] == 'U')
                    {
                        vowels++;
                    }
                }
                return vowels;
            }

            Console.WriteLine($"\nNumarul de vocale din sirul de caractere introdus este egal cu: {CountVowels(GetString())}");
        }
    }
}

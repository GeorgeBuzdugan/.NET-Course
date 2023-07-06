using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura
            este sau nu palindrom*/

            static string GetString()
            {
                Console.WriteLine("Introduceti un cuvant: \n");
                return Console.ReadLine();
            }

            static bool IsPalindrome(string word)
            {
                int j = word.Length - 1;
                for (int i = 0; i < (word.Length - 1) / 2; i++)
                {
                    if (word[i] != word[j])
                    {
                        return false;
                    }
                    j--;
                }
                return true;
            }

            string word = GetString();
            string isPalindrome = IsPalindrome(word) ? "" : " nu";

            Console.WriteLine($"\nCuvantul introdus{isPalindrome} este un palindrom.");
        }
    }
}

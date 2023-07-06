using System;

namespace lab3ex2
{
    class Program
    {
        /*Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
        siruri de caractere fiind citite de la tastatura*/
        static void Main(string[] args)
        {
            static string GetString()
            {
                Console.WriteLine("Introduceti un sir de caractere: \n");
                return Console.ReadLine();
            }

            static string GetSubstring()
            {
                Console.WriteLine("\nIntroduceti un sir de caractere continut in primul sir de caractere: \n");
                return Console.ReadLine();
            }

            static void FindIndexOfSubString(string initalString, string substring)
            {
                Console.WriteLine($"\nSubstring-ul apare intre indexul {initalString.IndexOf(substring)} si {initalString.IndexOf(substring) + substring.Length}");
            }

            string initialString = GetString();
            string substring = GetSubstring();

            FindIndexOfSubString(initialString, substring);
        }
    }
}

using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        /* Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
        tastaura */
        {
            Console.WriteLine("Introduceti un numar: ");
            Console.WriteLine("Ultima cifra a numarului intreg introdus este: " + int.Parse(Console.ReadLine()) % 10);
        }
    }
}

using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        /*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
        impar
        In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.*/
        {
            Console.WriteLine("Introduceti un numar: ");
            float number = float.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("Par");
            else Console.WriteLine("Impar");
        }
    }
}

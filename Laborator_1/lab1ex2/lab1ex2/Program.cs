using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        /* Scrieti un program care va calcula media aritmetica a trei numere citite de la
        tastatura */
        {
            int suma = 0;
            Console.WriteLine("Introduceti primul numar:");
            suma += int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar");
            suma += int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar");
            suma += int.Parse(Console.ReadLine());
            Console.WriteLine("Media aritmetica este egala cu: " + suma / 3);
        }
    }
}

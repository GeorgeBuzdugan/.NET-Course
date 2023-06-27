using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
        descrescatoare.
        • Exemplu: citim 3,9,0 Afisam : 9 3 0*/
        {
            float[] numbers = new float[3];
            Console.WriteLine("Introduceti primul numar:");
            numbers[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            numbers[1] = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            numbers[2] = float.Parse(Console.ReadLine());
            Array.Sort(numbers);
            Console.WriteLine(numbers[2] + "," + numbers[1] + "," + numbers[0]);
        }
    }
}

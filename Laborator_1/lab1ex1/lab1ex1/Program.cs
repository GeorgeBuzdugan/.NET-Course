using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        /* Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
        paralelipiped dreptunghic, va afisa volumul lui */
        {
            Console.WriteLine("Introduceti lungimea paralelipipedului dreptunghic:");
            Int32 lungimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea paralelipipedului dreptunghic:");
            Int32 latimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea paralelipipedului dreptunghic:");
            Int32 inaltimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Volumul paralelipipedului dreptunghic este egal cu " + lungimea * latimea * inaltimea);
        }
    }
}
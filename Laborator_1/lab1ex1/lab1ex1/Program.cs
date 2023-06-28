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
            int lungimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea paralelipipedului dreptunghic:");
            int latimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea paralelipipedului dreptunghic:");
            int inaltimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Volumul paralelipipedului dreptunghic este egal cu " + lungimea * latimea * inaltimea);
        }
    }
}
using System;

namespace lab4ex2
{
    class Program
    {
        /*Scrieti un program care va modela un autoturism. Un autoturism va avea o
        marca (string), un numar de inmatriculare (string), precum si o
        capacitate cilindrica(int).
        Autoturismul va avea:
            Campurile corespunzatoare caracteristicilor autoturismului.
            Un constructor care va initializa campurile acestuia
            O metoda “GetDescription” care va returna descrierea acestuia sub forma : “marca,
            numarDeInmatriculare, capacitateCilindrica”.*/

        /// <summary>
        /// Class for Car
        /// </summary>
        public class Car
        {
            /// <summary>
            /// The model of the car
            /// </summary>
            private readonly string model;
            /// <summary>
            /// The registration number (license plate)
            /// </summary>
            private readonly string registrationNumber;
            /// <summary>
            /// The cilinder capacity
            /// </summary>
            private readonly int cilinderCapacity;

            /// <summary>
            /// The constructor for the Car class
            /// </summary>
            /// <param name="model">A string that represents the model of the car</param>
            /// <param name="registrationNumber">A string that represents the registration number</param>
            /// <param name="cilinderCapacity">A integer that represents the cilinder capacity of the car.</param>
            public Car(string model, string registrationNumber, int cilinderCapacity)
            {
                this.model = model;
                this.registrationNumber = registrationNumber;
                this.cilinderCapacity = cilinderCapacity;
            }

            /// <summary>
            /// A method that returns the model, registration number and cilinder capacity.
            /// </summary>
            /// <returns>Returns a string with the model, registration number and cilinder capacity</returns>
            public string GetDescription()
            {
                return $"{model}, {registrationNumber}, {cilinderCapacity}";
            }
        }
        static void Main(string[] args)
        {
            Car tesla = new Car("Tesla", "CJ 02 ABC", 23);
            Car ford = new Car("Ford", "CJ 10 BCD", 55);
            Console.WriteLine($"{tesla.GetDescription()}\n{ford.GetDescription()}");
        }
    }
}

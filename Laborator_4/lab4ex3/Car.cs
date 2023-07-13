using System;
using System.Collections.Generic;
using System.Text;

namespace lab4ex3
{
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
        /// The list of passengers
        /// </summary>
        private readonly List<string> passengers;

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
            passengers = new List<string>();
        }

        /// <summary>
        /// Adds a passenger to the list of passengers
        /// </summary>
        /// <param name="passenger">The name of the passenger to be added</param>
        public void AddPassenger(string passenger)
        {
            passengers.Add(passenger);
        }

        /// <summary>
        /// Deletes a passenger to the list of passengers
        /// </summary>
        /// <param name="passenger">The name of the passenger to be deleted</param>
        public void DeletePassenger(string passenger)
        {
            passengers.Remove(passenger);
        }

        /// <summary>
        /// Checks if a passenger is inside the car
        /// </summary>
        /// <param name="passenger">The name of the passenger that needs to be checked if it is inside the car</param>
        /// <returns>True if the passenger is inside the car, false otherwise.</returns>
        public bool IsInside(string passenger)
        {
            return passengers.Contains(passenger);
        }

        /// <summary>
        /// A method that returns the model, registration number and cilinder capacity.
        /// </summary>
        /// <returns>Returns a string with the model, registration number and cilinder capacity</returns>
        public string GetDescription()
        {
            return $"{model}, {registrationNumber}, {cilinderCapacity}, List of passengers: {string.Join(", ", passengers)}";
        }
    }
}

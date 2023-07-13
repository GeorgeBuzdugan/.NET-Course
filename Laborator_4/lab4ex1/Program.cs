using System;

namespace lab4ex1
{
    class Program
    {
        /*Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
        metoda care va calcula volumul acestuia.
        Folositi o clasa care va modela un dulap.
            Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
            Cele trei campuri vor fi initializate cu ajutorul constructorului
            Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.*/

        public class Dulap
        {
            private readonly int lungime, latime, inaltime;

            public Dulap(int lungime, int latime, int inaltime)
            {
                this.lungime = lungime;
                this.latime = latime;
                this.inaltime = inaltime;
            }

            public int GetVolume()
            {
                return lungime * latime * inaltime;
            }
        }
        static void Main(string[] args)
        {
            Dulap dulap = new Dulap(3, 4, 5);
            Console.WriteLine(dulap.GetVolume());
        }
    }
}

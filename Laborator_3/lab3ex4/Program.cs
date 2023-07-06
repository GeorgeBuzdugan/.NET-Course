using System;
using System.Globalization;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un program care va normaliza un sir de caractere citit de la tastatura astfel incat
            fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind
            transformate in litere mici.*/

            static string GetString()
            {
                Console.WriteLine("Introduceti un sir de caractere: \n");
                return Console.ReadLine();
            }
            
            static string FormatString(string initialString)
            {
                return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(initialString.ToLowerInvariant());
            }

            Console.WriteLine($"\nSirul de caractere formatat este: {FormatString(GetString())}");
        }
    }
}

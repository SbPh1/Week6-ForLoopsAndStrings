using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema eesnimi
            //programm kuvab kasutaja eesnime tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine(firstName[0]);

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Teie eesnimi on {firstNameLenght} sümbolit pikk");

            //viimase tähe indeks = firstNameLenght - 1
            Console.WriteLine(firstName[firstNameLenght-1]);
        }
    }
}

using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanimi
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Sisestad oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestad oma perekonnanimi:");
            string familyName = Console.ReadLine();


            if (firstName.Length > familyName.Length)
            {
                Console.WriteLine("Eesnimi on pikem");
            }
            else if (firstName.Length < familyName.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem");
            }
            else
            {
                Console.WriteLine("sama pikad");
            }
        }
    }
}

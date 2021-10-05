using System;

namespace StringReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajal sisestada eesnime
            //programm kuvab eesnime tähthaaval tagurpidi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(firstName[i]);
            }
        }
    }
}

using System;

namespace StringAndForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajal sisestada eesnime
            //programm kuvab eesnime tähthaaval

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine(firstName[i]);
            }
        }
    }
}

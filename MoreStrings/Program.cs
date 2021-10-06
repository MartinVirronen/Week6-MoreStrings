using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanimi 
            //programm tervitab kasutajat kasutades tema initsiaale
            //intsiaalid lõpevad punktiga

            Console.WriteLine("Sisesta on nimi");
            string eesnimi = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi");
            string perekonnanimi = Console.ReadLine();

            Console.WriteLine($"Tere, {eesnimi[0]}. {perekonnanimi[0]}. ");






        }
    }
}

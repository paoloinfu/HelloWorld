using HelloWorld.Nuova_cartella;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person luca = new Person("Luca", "Lippi");
            luca.eta = 18;

            Console.WriteLine(luca.Anagrafica());

            Person giovanni = luca;

            giovanni.nome = "Giovanni";

            Console.WriteLine(luca.Anagrafica());
            Console.WriteLine(giovanni.Anagrafica());
        }
    }
}

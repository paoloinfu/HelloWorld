using HelloWorld.Nuova_cartella;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Luca", "Lippi");
            luca.eta = 18;

            Console.WriteLine(p.Anagrafica());

            Person giovanni = luca;
            giovanni.nome = "Giovanni";


        }
    }
}

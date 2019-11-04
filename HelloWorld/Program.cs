using HelloWorld.Nuova_cartella;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Luca", "Lippi");
            Console.WriteLine(p.Anagrafica());
        }
    }
}

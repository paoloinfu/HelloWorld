using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Nuova_cartella
{
    class Person
    {
        public string nome;
        public string cognome;
        public int età;
        public string sesso;
        public int altezza;
        public double peso;

        public Person(string nome, string cognome)
        {
            this.nome = nome;
                this.cognome = cognome;
            this.sesso = "sconosciuto";
        }

        public string Anagrafica()
        {
            string anagrafica = this.nome + this.cognome;
            return anagrafica;
        }
    }
}

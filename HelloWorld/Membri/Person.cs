using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Nuova_cartella
{
    class Person
    {
        public string name;
        public string surname;
        public int eta;
        public string sesso;
        public int altezza;
        public double peso;

        public Person(string nome, string cognome)
        {
            this.name = nome;
            this.surname = cognome;
            this.sesso = "sconosciuto";
        }

        public string Anagrafica()
        {
           
            string anagrafica = this.name + " " + this.surname;
            return anagrafica;
        }

        public Person(string name, string surname, int height, double weight)
        {
            this.name = name;
            this.surname = surname;
            this.peso = weight;
            this.altezza = height;

        }
           
        public double calcBMI()
        {
            double heightInMeters = (double)this.altezza / 100;
            double bMI = this.peso / heightInMeters * heightInMeters;

            return bMI;

        }
    }
}

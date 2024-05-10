﻿using System.Security.Cryptography.X509Certificates;

namespace la_mia_pizzeria_static.Models
{

    
    public class Pizze
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string UrlFoto { get; set; }
        public double Prezzo { get; set; }

        public Pizze(string nome, string descrizione, string urlfoto, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            UrlFoto = urlfoto;
            Prezzo = prezzo;
        }
    }
}

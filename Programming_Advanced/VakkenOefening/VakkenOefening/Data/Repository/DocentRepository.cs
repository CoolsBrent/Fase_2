using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DocentRepository
    {
        public List<Docent> Docenten = new()
        {
            new Docent() { Id= 1,Voornaam = "Bart", Naam = "Ooms"},
            new Docent() { Id= 2,Voornaam = "Maxim", Naam = "Caers"},
            new Docent() { Id= 3,Voornaam = "Thomas", Naam = "Gielis"},
            new Docent() { Id= 4,Voornaam = "Sebastiaan", Naam = "Hennau"},
            new Docent() { Id= 5,Voornaam = "Jeff", Naam = "Mesens"},
            new Docent() { Id= 6,Voornaam = "Pieter", Naam = "De Cleyn"},
            new Docent() { Id= 7,Voornaam = "Mieke", Naam = "Smaers"},
            new Docent() { Id= 8,Voornaam = "Karen", Naam = "Verwsijvel"},
            new Docent() { Id= 9,Voornaam = "Koen", Naam = "Lenaerts"},
            new Docent() { Id= 10,Voornaam = "Niels", Naam = "Mangelschots"},
            new Docent() { Id= 11,Voornaam = "Stijn", Naam = "Willekens"},
            new Docent() { Id= 12,Voornaam = "Kris", Naam = "De Cock"},
            new Docent() { Id= 13,Voornaam = "Joren", Naam = "Synaeve"},
            new Docent() { Id= 14,Voornaam = "Joeri", Naam = "Verlooy"}
        };

        // Methode om de werknemers op te vragen
        public List<Docent> GetDocenten()
        {
            return Docenten;
        }
    }
}
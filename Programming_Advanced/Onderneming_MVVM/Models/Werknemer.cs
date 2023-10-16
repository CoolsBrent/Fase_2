using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    // All the code in this file is included in all platforms.
    public class Werknemer

    {
        public string Achternaam { get; set; }
        public string Avatar { get; set; }
        public string Functie { get; set; }
        public DateTime Geboortedatum { get; set; }
        public int Id { get; set; }

        public DateTime InDienst { get; set; }
        public string VolledigeNaam => $"{Voornaam} {Achternaam}";
        public string Voornaam { get; set; }
    }
}
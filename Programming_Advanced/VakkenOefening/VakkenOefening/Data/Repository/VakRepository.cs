using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VakRepository
    {
        public List<Vak> Vakken = new()
        {
        new Vak() {Id=1 ,Naam="Programming Advanced", Afbeelding="programming_advanced.png", ColumnNumberGrid=0, RowNumberGrid=1 },
        new Vak() {Id=2 ,Naam="Frontend Frameworks", Afbeelding="frontend_frameworks.png", ColumnNumberGrid=1, RowNumberGrid=1 },
        new Vak() {Id=3 ,Naam="It Professional 2", Afbeelding="it_professional2.png", ColumnNumberGrid=0, RowNumberGrid=2 },
        new Vak() {Id=4 ,Naam="Interactieve Websites", Afbeelding="interactieve_websites.png", ColumnNumberGrid=1, RowNumberGrid=2 },
        new Vak() {Id=5 ,Naam="Statische Websites", Afbeelding="statische_websites.png", ColumnNumberGrid=0, RowNumberGrid=3 }
        };

        public List<Vak> GetVakken(bool includeDocenten = true, int? vakId = null)
        {
            DocentRepository docentRepository = new DocentRepository();
            var Docenten = docentRepository.GetDocenten();
            Vakken[0].Docenten = new List<Docent> { Docenten[0], Docenten[1] };
            Vakken[1].Docenten = new List<Docent> { Docenten[2], Docenten[3], Docenten[4] };
            Vakken[2].Docenten = new List<Docent> { Docenten[5], Docenten[6], Docenten[7] };
            Vakken[3].Docenten = new List<Docent> { Docenten[0], Docenten[8] };
            Vakken[4].Docenten = new List<Docent> { Docenten[0], Docenten[2], Docenten[9], Docenten[10], Docenten[12], Docenten[13] };
            if (vakId.HasValue)
            {
                // Als een vakId is opgegeven, haal alleen dat vak op met optionele docenten.
                var vak = Vakken.FirstOrDefault(v => v.Id == vakId);
                if (vak != null)
                {
                    if (!includeDocenten)
                    {
                        // Verwijder docentgegevens als deze niet nodig zijn.
                        vak.Docenten = null;
                    }
                    return new List<Vak> { vak };
                }
            }
            else
            {
                if (!includeDocenten)
                {
                    // Verwijder docentgegevens voor alle vakken als deze niet nodig zijn.
                    foreach (var vak in Vakken)
                    {
                        vak.Docenten = null;
                    }
                }
                return Vakken;
            }
            return null; // VakId niet gevonden.
        }
    }
}
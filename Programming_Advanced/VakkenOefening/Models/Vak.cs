﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vak
    {
        public string Afbeelding { get; set; }
        public int ColumnNumberGrid { get; set; }
        public DateTime DatumEersteLes { get; set; }
        public IEnumerable<Docent> Docenten { get; set; }
        public bool HeeftVastLokaal { get; set; }
        public int Id { get; set; }
        public Campus Locatie { get; set; }
        public string Naam { get; set; }
        public int RowNumberGrid { get; set; }
        public IEnumerable<Docent> Studenten { get; set; }
        public char VastLokaalBlok { get; set; }
        public int VastLokaalNummer { get; set; }
        public int VerwachteScore { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFPAServices.Metier
{
    class Qualification
    {
        public sbyte CodeQualif { get; set; }
        public string Libelle { get; set; }
        public decimal PvJournee { get; set; }
        public Qualification(sbyte codequali, string libelle, decimal pvjournee)
        {
            CodeQualif = codequali;
            Libelle = libelle;
            PvJournee = pvjournee;
        }
    }
}

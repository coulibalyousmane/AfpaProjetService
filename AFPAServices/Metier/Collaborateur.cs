using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPAServices.Metier
{
    class Collaborateur
    {
        public int CodeColl { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public DateTime DEmbauche { get; set; }
        public decimal PrJournalier { get; set; }
        public Qualification LaQualif { get; set; }
        public Collaborateur(int codecoll, string nom, string prenom, DateTime dembauche, decimal prjournalier, Qualification qualif)
        {
            CodeColl = codecoll;
            Nom = nom;
            PreNom = prenom;
            DEmbauche = dembauche;
            PrJournalier = prjournalier;
            LaQualif = qualif;
        }
        public override string ToString()
        {
            return Nom + "," + PreNom + "," + DEmbauche + "," + PrJournalier + "," + LaQualif;
        }
    }
}

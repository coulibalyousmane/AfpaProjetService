using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFPAServices.Metier
{
    class ProjetRegie : Projet
    {
        public decimal TarifJournalier { get; set; }
        public Qualification Qualification { get; set; }
        public ProjetRegie(int codeprojet, string nomprojet, DateTime ddbut, DateTime df, Client leclient, string contact, string mail, Collaborateur collab,decimal tarif, Qualification qualific) : base(codeprojet, nomprojet, ddbut, df, leclient, contact, mail, collab)
        {
            TarifJournalier = tarif;
            Qualification = qualific;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFPAServices.Metier
{
    class ProjetForfait : Projet
    {
        public decimal MontantContrat { get; set; }
        public Penalite PenaliteOuiNon { get; set; }
        public Collaborateur ChefDeProjet { get; set; }
        private List<Prevision> previsions;


        public ProjetForfait(int codeprojet, string nomprojet, DateTime ddbut, DateTime df, Client leclient, string contact, string mail, decimal mt, Penalite p, Collaborateur cl, List <Prevision> prev) : base(codeprojet, nomprojet, ddbut, df, leclient, contact, mail, cl)
        {
            MontantContrat = mt;
            PenaliteOuiNon = p;
            ChefDeProjet = cl;
            previsions = prev;
        }

        public ProjetForfait(int codeprojet, string nomprojet, DateTime ddbut, DateTime df, Client leclient, string contact, string mail, decimal mt, Penalite p, Collaborateur cl) : base(codeprojet, nomprojet, ddbut, df, leclient, contact, mail, cl)
        {
            MontantContrat = mt;
            PenaliteOuiNon = p;
            ChefDeProjet = cl;
        }




    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFPAServices.Metier
{
    abstract class Projet
    {
        public int CodeProjet { get; set; }
        //public int CodeProjet
        //{
        //    get
        //    { return CodeProjet; }
        //    set
        //    { CodeProjet = value; }
        //}
        public string NomProjet { get; set; }
        public DateTime DDebut { get; set; }
        public DateTime DFin { get; set; }
        public Client LeClient { get; set; }
        public string Contact { get; set; }
        public string MailContact { get; set; }
        public Collaborateur LeCollaborateur { get; set; }


        public Projet(int codeprojet, string nomprojet, DateTime ddbut, DateTime df, Client leclient, string contact, string mail, Collaborateur collab)
        {
            CodeProjet = codeprojet;
            NomProjet = nomprojet;
            DDebut = ddbut;
            DFin = df;
            LeClient = leclient;
            Contact = contact;
            MailContact = mail;
            LeCollaborateur = collab;
        }
        public override string ToString()
        {
            return CodeProjet + "," + NomProjet + "," + DDebut + "," + DFin + Contact +"," + MailContact + "," + LeClient + "," + LeCollaborateur;
        }



    }
}

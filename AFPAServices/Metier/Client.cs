using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPAServices.Metier
{
    class Client
    {
        public int CodeClient { get; set; }
        public string RaisonSociale { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public Client( int code, string raison, string adresse1, string adresse2, string cp, string ville, string telephone, string mail )
        {
            CodeClient = code;
            RaisonSociale = raison;
            Adresse1 = adresse1;
            Adresse2 = adresse2;
            CP = cp;
            Ville = ville;
            Telephone = telephone;
            Mail = mail;

        }
        public override string ToString()
        {
            return RaisonSociale  + "," + Adresse1 + "," + Telephone ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPAServices.Metier
{
    class Prevision
    {
        public Qualification LaQualif { get; set; }
        public short NbJours { get; set; }
        public Prevision(Qualification laqualif, short nbjours)
        {
            LaQualif = laqualif;
            NbJours = nbjours;
        }
    }
}

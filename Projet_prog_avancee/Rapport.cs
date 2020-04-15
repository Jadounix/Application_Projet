using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Rapport : Livrable
    {
        private int _nbPages;

        //Constructeur
        public Rapport(string dateRendu, int nbPages) : base(dateRendu)
        {
            _nbPages = nbPages;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "**RAPPORT**\nDate de rendu : " + _dateRendu + " | Nombre de pages : " + _nbPages + "\n";
            return chS;
        }
    }
}

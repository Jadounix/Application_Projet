using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projet_prog_avancee
{
    [Serializable]
    public class Soutenance : Livrable
    {
        private int _duree;

        //Constructeur

        public Soutenance() : base() //necessaire pour xml
        {
            _duree = 30;
        }

        public Soutenance(string dateRendu, int duree) : base(dateRendu)
        {
            _duree = duree;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "**SOUTENANCE**\nDate de rendu : " + _dateRendu + " | Durée de la soutenance : " + _duree + "\n";
            return chS;
        }
    }
}

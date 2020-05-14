using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projet_prog_avancee
{
    [Serializable]
    [XmlInclude(typeof(Soutenance))]
    [XmlInclude(typeof(Rapport))]
    public abstract class Livrable
    {
        protected string _dateRendu;

        //Constructeur
        public Livrable() //necessaire pour xml
        {
            _dateRendu = "date";
        }

        public Livrable(string dateRendu)
        {
            _dateRendu = dateRendu;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Date de rendu : " + _dateRendu + "\n";
            return chS;
        }
    }
}

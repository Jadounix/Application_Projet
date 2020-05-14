using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projet_prog_avancee
{
    [Serializable]
    [XmlInclude(typeof(Eleve))]
    [XmlInclude(typeof(Professeur))]
    [XmlInclude(typeof(Exte))]
    public abstract class Intervenant //Classe abstraite
    {
        public string _nom { get; set; }
        public string _prenom { get; set; }
        public string _role { get; set; }

        //Constructeur
        public Intervenant()//necessaire pour xml
        {
            _nom = "Nom";
            _prenom = "Prenom";
            _role = "intervenant";
        }

        public Intervenant(string nom, string prenom, string role)
        {
            _nom = nom;
            _prenom = prenom;
            _role = role;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Nom : " + _nom + " | Prénom : " + _prenom + " | Rôle : " + _role + "\n";
            return chS;
        }
    }
}

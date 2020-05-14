using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    [Serializable]
    public abstract class Intervenant //Classe abstraite
    {
        public string _nom { get; set; }
        public string _prenom { get; set; }
        public string _role { get; set; }

        //Constructeur
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

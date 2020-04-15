using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Exte : Intervenant
    {
        private string _entreprise;

        //Constructeur
        public Exte(string entreprise, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _entreprise = entreprise;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Nom : " + _nom + " | Prénom : " + _prenom + " | Rôle : " + _role + " | Entreprise : " + _entreprise + "\n";
            return chS;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Eleve : Intervenant
    {
        public int _promotion;

        //Constructeur
        public Eleve(int promotion, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _promotion = promotion;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Nom : " + _nom + " | Prénom : " + _prenom + " | Rôle : " + _role + " | Promotion : " + _promotion + "\n";
            return chS;
        }
    }
}

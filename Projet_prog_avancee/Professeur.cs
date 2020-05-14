using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    public class Professeur : Intervenant
    {
        private string _matiere;

        //Constructeur
        public Professeur() : base()//necessaire pour xml
        {
            _matiere = "matière";
        }

        public Professeur(string matiere, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _matiere = matiere;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Nom : " + _nom + " | Prénom : " + _prenom + " | Rôle : " + _role + " | Matière : " + _matiere + "\n";
            return chS;
        }


    }
}

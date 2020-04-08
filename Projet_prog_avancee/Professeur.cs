using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Professeur : Intervenant
    {
        private string _matiere;

        //Constructeur
        public Professeur(string matiere, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _matiere = matiere;
        }
    }
}

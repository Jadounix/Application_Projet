using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Enseignant : Intervenant
    {
        protected string _matiere { get; set; }

        //Constructeur
        public Enseignant(string nom, string prenom, string role, string matiere) : base(nom, prenom, role)
        {
            _matiere = matiere;
        }

    }
}

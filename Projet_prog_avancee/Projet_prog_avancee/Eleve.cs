using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Eleve : Intervenant
    {
        protected int _promo { get; set; }
        protected string _anneeScolaire { get; set; }

        //Constructeur
        public Eleve(string nom, string prenom, string role, int promo, string anneeScolaire) : base(nom, prenom, role)
        {
            _promo = promo;
            _anneeScolaire = anneeScolaire;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Intervenant
    {
        protected string _nom { get; set; }
        protected string _prenom { get; set; }
        protected string _role { get; set; }
        protected int _promo { get; set; }
        protected string _anneeScolaire { get; set; }
        protected List<string> _listeMatieres;


        //Constructeur
        public Intervenant(string nom, string prenom, string role, int promo, string anneeScolaire)
        {
            _nom = nom;
            _prenom = prenom;
            _role = role;
            _promo = promo;
            _anneeScolaire = anneeScolaire;
            _listeMatieres = new List<string>();
        }

    }
}

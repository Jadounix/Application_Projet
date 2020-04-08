using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    abstract class Intervenant
    {
        protected string _nom { get; set; }
        protected string _prenom { get; set; }
        protected string _role { get; set; }


        //Constructeur
        public Intervenant(string nom, string prenom, string role)
        {
            _nom = nom;
            _prenom = prenom;
            _role = role;
        }

    }
}
